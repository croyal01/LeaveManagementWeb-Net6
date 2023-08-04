﻿using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{
	public class EmployeesController : Controller
	{

		private readonly UserManager<Employee> userManager;
		private readonly IMapper mapper;
		private readonly ILeaveAllocationRepository leaveAllocationRepository;
		private readonly ILeaveTypeRepository leaveTypeRepository;
		public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository)
		{
			this.userManager = userManager;
			this.mapper = mapper;
			this.leaveAllocationRepository = leaveAllocationRepository;
			this.leaveTypeRepository = leaveTypeRepository;
		}
		// GET: EmployeesController
		public async Task<IActionResult> Index()
		{
			var employees = await userManager.GetUsersInRoleAsync(Roles.User);
			var model = mapper.Map<List<EmployeeListVM>>(employees);
			return View(model);
		}

		// GET: EmployeesController/ViewAllocation/5
		public async Task<ActionResult> ViewAllocations(string id)
		{
			var model = await leaveAllocationRepository.GetEmployeeAllocations(id);

			return View(model);
		}

		// GET: EmployeesController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: EmployeesController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: EmployeesController/Edit/5
		public async Task<ActionResult> EditAllocation(int id)
		{
			var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
			if (model == null)
			{
				return NotFound();
			}

			return View(model);
		}

		// POST: EmployeesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditLVM model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					if (await leaveAllocationRepository.UpdateEmployeeAllocation(model))
					{
						return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
					}
				}

					//if (ModelState.IsValid)
					//{
					//	var leaveAllocation = await leaveAllocationRepository.GetAsync(model.Id);
					//	if (leaveAllocation == null)
					//	{
					//		return NotFound();
					//	}
					//	leaveAllocation.Period = model.Period;
					//	leaveAllocation.NumberofDays = model.NumberofDays;
					//	await leaveAllocationRepository.UpdateAsync(leaveAllocation);
					//	//return RedirectToAction(nameof(Index));
					//	return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
					//}

			}
			catch (Exception ex)
			{
				ModelState.AddModelError(string.Empty, "An Error has occured. Please try again later.");
				//return View();
			}
			model.Employee = mapper.Map<EmployeeListVM>(userManager.FindByIdAsync(model.EmployeeId));
			model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
			return View(model);
		}

		// GET: EmployeesController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: EmployeesController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
