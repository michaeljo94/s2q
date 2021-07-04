using s2q.Controller;
using s2q.UI;

namespace s2q.Model.Actions
{
    public class ListSearchAction:IAction
    {
        private ActionController _actionController;
        private ListDisplay display;
        public ListSearchAction()
        {
            this._actionController = ActionController.GetInstance();
            this.display = new ListDisplay("Search Engines" , this._actionController.GetActionsKeys());
        }

        public void Run()
        {
            this.display.Draw();
        }
    }
}