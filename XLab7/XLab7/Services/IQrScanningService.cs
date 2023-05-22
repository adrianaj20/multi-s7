using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace XLab7.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
