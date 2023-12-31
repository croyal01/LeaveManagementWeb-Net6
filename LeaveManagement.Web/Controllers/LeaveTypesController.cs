﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using AutoMapper;
using LeaveManagement.Common.Models;
using LeaveManagement.Application.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Common.Constants;

namespace LeaveManagement.Web.Controllers
{
	[Authorize(Roles = Roles.Administrator)]
	public class LeaveTypesController : Controller
	{
		//private readonly ApplicationDbContext _context;
		private readonly ILeaveTypeRepository leaveTypeRepository;
		private readonly IMapper mapper;
		private readonly ILeaveAllocationRepository leaveAllocationRepository;

		//public LeaveTypesController(ApplicationDbContext context, IMapper mapper)
		public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
		{
			//_context = context;
			this.leaveTypeRepository = leaveTypeRepository;
			this.mapper = mapper;
			this.leaveAllocationRepository = leaveAllocationRepository;
		}

		// GET: LeaveTypes
		public async Task<IActionResult> Index()
		{

			//this also works
			var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());
			return View(leaveTypes);

		}

		public async Task<IActionResult> Details(long? id)
		{
			var leaveType = await leaveTypeRepository.GetAsync(id.Value);

			if (leaveType == null)
			{
				return NotFound();
			}
			var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
			return View(leaveTypeVM);
		}


		// GET: LeaveTypes/Create
		public IActionResult Create()
		{
			return View();
		}


		// POST: LeaveTypes/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
		{
			//if (ModelState.IsValid)
			//{
			//	var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
			//	_context.Add(leaveType);
			//	await _context.SaveChangesAsync();
			//	return RedirectToAction(nameof(Index));
			//}
			if (ModelState.IsValid)
			{
				var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
				await leaveTypeRepository.AddAsync(leaveType);
				await leaveTypeRepository.UpdateAsync(leaveType); ;
				return RedirectToAction(nameof(Index));
			}
			return View(leaveTypeVM);
		}


		public async Task<IActionResult> Edit(long? id)
		{
			if (id == null || leaveTypeRepository == null)
			{
				return NotFound();
			}

			var leaveType = await leaveTypeRepository.GetAsync(id.Value);
			if (leaveType == null)
			{
				return NotFound();
			}
			var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);//await _context.LeaveTypes.FindAsync(id);
			return View(leaveTypeVM);
		}

		// POST: LeaveTypes/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(long id, LeaveTypeVM leaveTypeVM)
		//public async Task<IActionResult> Edit(long id, [Bind("Name,DefaultDays,Id,DateCreated,DateModified")] LeaveType leaveType)
		{
			if (id != leaveTypeVM.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
					await leaveTypeRepository.UpdateAsync(leaveType); // _context.Update(leaveType);
																	  //await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!LeaveTypeExists(leaveTypeVM.Id))
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
			return View(leaveTypeVM);
		}

		// GET: LeaveTypes/Delete/5
		public async Task<IActionResult> Delete(long? id)
		{
			//if (id == null || _context.LeaveTypes == null)
			if (id == null || leaveTypeRepository == null)
			{
				return NotFound();
			}

			var leaveType = await leaveTypeRepository.GetAsync(id.Value);

			if (leaveType == null)
			{
				return NotFound();
			}

			return View(leaveType);
		}

		// POST: LeaveTypes/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(long id)
		{
			await leaveTypeRepository.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AllocateLeave(int id)
		{
			
			await leaveAllocationRepository.LeaveAllocation(id);
			return RedirectToAction(nameof(Index));
		}



		private bool LeaveTypeExists(long id)
		{
			return leaveTypeRepository.GetAsync(id) != null;
		}
	}
}
