using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMTools.Lib
{
  public class MenuHandler
  {
      private Commands2 Commands { get; set; }

      public MenuHandler()
      {
          this.Commands = RMTSession.ApplicationContext.CommandBars;
      }

      private void CreateMainMenu()
      {
          //Command command = commands.AddNamedCommand2(_addInInstance, "RMTools", "RMTools", "Executes the command for RMTools", true, 59, ref contextGUIDS, (int)vsCommandStatus.vsCommandStatusSupported + (int)vsCommandStatus.vsCommandStatusEnabled, (int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton);
      }
  }
}