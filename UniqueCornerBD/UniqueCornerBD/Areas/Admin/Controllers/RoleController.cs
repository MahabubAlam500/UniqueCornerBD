using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Threading.Tasks;
using UniqueCornerBD.Areas.Admin.Models;
using UniqueCornerBD.Data;

namespace UniqueCornerBD.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<IdentityUser> _userManager;
        ApplicationDbContext _context;
        public RoleController(RoleManager<IdentityRole> roleManager, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var Roles = _roleManager.Roles.ToList();
            ViewBag.role = Roles;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {

            IdentityRole role = new IdentityRole();
            role.Name = name;
            var isExit = await _roleManager.RoleExistsAsync(role.Name);
            if (isExit)
            {
                ViewBag.msg = "This Role Is Already Exists";
                ViewBag.name = name;

                return View();
            }
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                TempData["save"] = "Role Has Been Saved Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task <IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id,string name)
        {

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            role.Name = name;
            var isExit = await _roleManager.RoleExistsAsync(role.Name);
            if (isExit)
            {
                ViewBag.msg = "This Role Is Already Exists";
                ViewBag.name = name;

                return View();
            }
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                TempData["save"] = "Role Has Been updated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;
            return View();
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(string id)
        {

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
      
       
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                TempData["Delete"] = "Role Has Been Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Assign()
        {

            ViewData["UserId"] = new SelectList(_context.applicationUsers.Where(m=>m.LockoutEnd<DateTime.Now ||m.LockoutEnd==null).ToList(), "Id", "UserName");
            ViewData["RoleId"] = new SelectList(_roleManager.Roles.ToList(), "Name", "Name");
            return View();
        }
        [HttpPost]
        public async Task <IActionResult>Assign(UserRoleVm userRole)
        {
         
            var role = _context.applicationUsers.FirstOrDefault(c => c.Id == userRole.UserId);
         
               bool Existrole = await _userManager.IsInRoleAsync(role, userRole.RoleId);
                if (Existrole)
                {
                    ViewBag.msg = "This user alredy assign this role";
                ViewData["UserId"] = new SelectList(_context.applicationUsers.Where(m => m.LockoutEnd < DateTime.Now || m.LockoutEnd == null).ToList(), "Id", "UserName");
                ViewData["RoleId"] = new SelectList(_roleManager.Roles.ToList(), "Name", "Name");
                return View();
                }
               
                    var result = await _userManager.AddToRoleAsync(role, userRole.RoleId);
                    if (result.Succeeded)
                    {
                        TempData["Save"] = "Role Has Been assigned";
                        return RedirectToAction(nameof(Index));
                    }
            return View();
        }


        public IActionResult AssignUserRole()
        {

            var result = from ur in _context.UserRoles
                         join r in _context.Roles on ur.RoleId equals r.Id
                         join a in _context.applicationUsers on ur.UserId equals a.Id
                         select new UserRoleMaping()
                         {
                             UserId = ur.UserId,
                             RoleId = ur.RoleId,
                             UserName = a.UserName,
                             RoleName = r.Name



                         };
            ViewBag.UserRoles = result;
            return View();
        }
          
           
         
        }
    }

