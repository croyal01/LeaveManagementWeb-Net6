using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using AutoMapper;
using LeaveManagement.Web.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace LeaveManagement.Web.Controllers
{
	[Authorize]
	public class LeaveRequestsController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper mapper;
		private readonly ILeaveRequestRepository leaveRequestRepository;
		public LeaveRequestsController(ApplicationDbContext context,  ILeaveRequestRepository leaveRequestRepository )		
		{
			_context = context;			
			this.leaveRequestRepository = leaveRequestRepository;

		}

		// GET: LeaveRequests
		public async Task<IActionResult> Index()
		{
			var applicationDbContext = _context.LeaveRequests.Include(l => l.LeaveType);
			return View(await applicationDbContext.ToListAsync());
		}

		// GET: LeaveRequests/Details/5
		public async Task<IActionResult> Details(long? id)
		{
			if (id == null || _context.LeaveRequests == null)
			{
				return NotFound();
			}

			var leaveRequest = await _context.LeaveRequests
				.Include(l => l.LeaveType)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (leaveRequest == null)
			{
				return NotFound();
			}

			return View(leaveRequest);
		}

		// GET: LeaveRequests/Create
		public IActionResult Create()
		{
			var model = new LeaveRequestCreateVM
			{

				LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name")

			};
			//ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id");

			return View(model);
		}

		// POST: LeaveRequests/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		//public async Task<IActionResult> Create([Bind("LeaveTypeId,StartDate,EndDate,Cancelled,Approved,DateRequested,RequestComments,RequestingEmployeeId,Id,DateCreated,DateModified")] LeaveRequest model)
		//LeaveRequestCreateVM
		public async Task<IActionResult> Create(LeaveRequestCreateVM model)

		{
			try
			{
				if (ModelState.IsValid)
				{
					await leaveRequestRepository.CreateLeaveRequest(model);

					//var leaveRequest = mapper.Map<LeaveRequestCreateVM>(_context.LeaveRequests);	
					//_context.Add(model);
					//await _context.SaveChangesAsync();
					return RedirectToAction(nameof(Create)); //Index
				}
			}
			catch (System.Exception e)
			{
				//var l = e.Message;
				//throw new Exception(l, e);
				ModelState.AddModelError(String.Empty, "An error has occurred. Please try again later");
			}
			model.LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
			return View(model);
		}

		// GET: LeaveRequests/Edit/5
		public async Task<IActionResult> Edit(long? id)
		{
			if (id == null || _context.LeaveRequests == null)
			{
				return NotFound();
			}

			var leaveRequest = await _context.LeaveRequests.FindAsync(id);
			if (leaveRequest == null)
			{
				return NotFound();
			}
			ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
			return View(leaveRequest);
		}

		// POST: LeaveRequests/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(long id, [Bind("LeaveTypeId,StartDate,EndDate,Cancelled,Approved,DateRequested,RequestComments,RequestingEmployeeId,Id,DateCreated,DateModified")] LeaveRequest leaveRequest)
		{
			if (id != leaveRequest.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(leaveRequest);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!LeaveRequestExists(leaveRequest.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
			return View(leaveRequest);
		}

		// GET: LeaveRequests/Delete/5
		public async Task<IActionResult> Delete(long? id)
		{
			if (id == null || _context.LeaveRequests == null)
			{
				return NotFound();
			}

			var leaveRequest = await _context.LeaveRequests
				.Include(l => l.LeaveType)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (leaveRequest == null)
			{
				return NotFound();
			}

			return View(leaveRequest);
		}

		// POST: LeaveRequests/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(long id)
		{
			if (_context.LeaveRequests == null)
			{
				return Problem("Entity set 'ApplicationDbContext.LeaveRequests'  is null.");
			}
			var leaveRequest = await _context.LeaveRequests.FindAsync(id);
			if (leaveRequest != null)
			{
				_context.LeaveRequests.Remove(leaveRequest);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public async Task<ActionResult> MyLeave()
		{
			var model = await leaveRequestRepository.GetMyLeaveDetails();
			return View(model);
		}

		private bool LeaveRequestExists(long id)
		{
			return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
		}

	}
}
