using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IUtilization
    {
        /// <summary>
        /// Commom method required for non inherting classes
        /// </summary>
        /// <returns>percent of utilization in product development</returns>
        int GetUtilization();
    }
}
