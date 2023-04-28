using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public static class LogProxy
    {
        public static readonly ILog log = LogManager.GetLogger("LogInfo");
        public static void Configure()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
