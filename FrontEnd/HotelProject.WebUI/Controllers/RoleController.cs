using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> roleManager;
        public RoleController(RoleManager<AppRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var values=roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel)
        {
            AppRole appRole = new AppRole()
            {
                Name = addRoleViewModel.Name,
            };
            var result= await roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value=roleManager.Roles.FirstOrDefault(x=>x.Id == id);
            await roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var value=roleManager.Roles.FirstOrDefault(x=>x.Id==id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel(){
                Id = value.Id,
                Name = value.Name,
            };
            return View(updateRoleViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value=roleManager.Roles.FirstOrDefault(x=>x.Id==updateRoleViewModel.Id);
            value.Name = updateRoleViewModel.Name;
            await roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }

    }
}
