using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppShellDemo.Services.DeviceInfoService
{
	public interface IDeviceInfoService
	{
		string GetDeviceModel();
		string GetManufacturer();
		string GetOperatingSystemVersion();
		string GetAppVersion();
		string GetAppName();
	}

}
