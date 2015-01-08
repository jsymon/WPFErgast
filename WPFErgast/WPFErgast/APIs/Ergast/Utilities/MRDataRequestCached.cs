using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFErgast.APIs.Ergast.Utilities
{
    public class MRDataRequestCached : MRDataRequest
    {
        private static Dictionary<int, object> _cachedGetResponseType = new Dictionary<int, object>();

        internal override T GetResponseType<T>()
        {
            var hashCode = this.GetHashCode();
            if (!_cachedGetResponseType.ContainsKey(hashCode))
            {
                var response = base.GetResponseType<T>();
                _cachedGetResponseType[hashCode] = response;
            }
            return (T)_cachedGetResponseType[hashCode];
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
