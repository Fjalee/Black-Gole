using System;
using System.Collections.Generic;

namespace Helpers
{
    [Serializable]
    public class JsonListWrapper<T>
    {
        public List<T> list;
        public JsonListWrapper(List<T> list) => this.list = list;
    }
}
