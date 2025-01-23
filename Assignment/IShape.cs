using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IShape
    {
        #region property
        double Area { get; }
        #endregion
        #region method
        void DisplayShapeInfo();
        #endregion
        
    }
}
