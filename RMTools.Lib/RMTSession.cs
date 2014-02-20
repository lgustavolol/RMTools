using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using EnvDTE80;

namespace RMTools.Lib
{
  public static class RMTSession
  {
    public static DTE2 ApplicationContext { get; set; }
    public static AddIn AddInInstanceContext { get; set; }
  }
}