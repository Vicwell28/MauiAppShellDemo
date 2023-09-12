using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppShellDemo.Services.DeviceInfoService
{
	public class DeviceInfoService : IDeviceInfoService
	{
		public string GetDeviceModel()
		{
			return DeviceInfo.Model;
		}

		public string GetManufacturer()
		{
			return DeviceInfo.Manufacturer;
		}

		public string GetOperatingSystemVersion()
		{
			return DeviceInfo.VersionString;
		}

		public string GetAppVersion()
		{
			return AppInfo.VersionString;
		}

		public string GetAppName()
		{
			return AppInfo.Name;
		}
	}

}
