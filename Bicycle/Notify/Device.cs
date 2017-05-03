using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NotifyByBicycle
{

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class Device
    {
        private List<object> _listeners = null;
        [ComVisible(false)]
        public List<object> Listeners
        {
            get
            {
                return _listeners;
            }
        }

        public void AddJavaScriptListener(object listener)
        {
            if (_listeners == null)
            {
                _listeners = new List<object>();
            }
            _listeners.Add(listener);
        }
        private object _listener = null;
        public object OnExternalEvent
        {
            get
            {
                return _listener;
            }
            set
            {
                _listener = value;
            }
        }
    }
}
