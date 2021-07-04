using System;
using System.Runtime.CompilerServices;
using s2q.Exceptions;
using s2q.Model.Actions;
using s2q.UI;

namespace s2q.Controller
{
    public class MainController
    {
        private ActionController _searchActionController;
        private CommandLineArgumentController _clac;

        public MainController(string[] args)
        {
            BuildActioStack();
            _clac = new CommandLineArgumentController(args);
            Run();
        }

        private void BuildActioStack()
        {
            _searchActionController = ActionController.GetInstance();
            _searchActionController.AppendAction("google", new SearchAction("google"));
            _searchActionController.AppendAction("youtube", new SearchAction("youtube"));
            _searchActionController.AppendAction("list", new ListSearchAction());
            _searchActionController = ActionController.GetInstance();
        }

        private void Run()
        {
            try
            {
                IAction action = this._searchActionController.GetActionByName(_clac.GetCommandArgs());
                action.Run();
            }
            catch (ActionNotFoundException e)
            {
                var display = new ErrorDisplay(e, "Try s2q search list to see all search providers ");
                display.Draw();
            }
        }
    }
}