using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeADriveComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
