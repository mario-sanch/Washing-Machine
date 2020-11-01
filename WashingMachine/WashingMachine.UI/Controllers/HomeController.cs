#region Libraries
using FSMDomain;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace WashingMachine.UI.Controllers
{
    public class HomeController : Controller
    {
        private MachineContext machineContext;

        public HomeController(MachineContext machineContext)
        {
            this.machineContext = machineContext;
        }

        public IActionResult Index()
        {
            machineContext.Start();
            return View(machineContext);
        }

        [HttpGet]
        public IActionResult ExecuteAction(string selection)
        {
            this.machineContext.CurrentState.ExecuteBahavior(this.machineContext, selection);

            return View("Index", this.machineContext);
        }
    }
}
