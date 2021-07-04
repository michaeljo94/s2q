using System.Collections.Generic;
using System.Linq;
using s2q.Exceptions;
using s2q.Model.Actions;

namespace s2q.Controller
{
    public class ActionController
    {
        private static ActionController _instance;
        private readonly Dictionary<string, IAction> _actions;

        private ActionController()
        {
            _instance = this;
            _actions = new Dictionary<string, IAction>();
        }

        public static ActionController GetInstance()
        {
            if (_instance == null) new ActionController();

            return _instance;
        }

        public void AppendAction(string key, IAction action)
        {
            _actions.Add(key, action);
        }

        public IAction GetActionByName(string actionName)
        {
            try
            {
                return _actions[actionName];
            }
            catch (KeyNotFoundException)
            {
                throw new ActionNotFoundException();
            }
        }

        public string[] GetActionsKeys()
        {
            return _actions.Keys.ToArray();
        }

        public List<IAction> GetActions()
        {
            var actions = new List<IAction>();
            foreach (var actionsValue in _actions.Values) actions.Append(actionsValue);

            return actions;
        }
    }
}