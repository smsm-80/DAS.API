using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Application.Model
{
    public class BaseSearchRequestVM
    {
        private int _PageIndex;
        private int _PageSize;
        public int PageIndex
        {
            get { return _PageIndex < 1 ? 1 : _PageIndex; }
            set { _PageIndex = value; }
        }
        public int PageSize
        {
            get { return _PageSize < 1 ? 10 : _PageSize; }
            set { _PageSize = value; }
        }
    }
}
