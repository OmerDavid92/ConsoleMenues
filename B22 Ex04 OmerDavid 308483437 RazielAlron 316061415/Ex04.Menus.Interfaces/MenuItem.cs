namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class MenuItem
    {
        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }

        private readonly List<IMenuItemClickObserver> m_ClickedObserver = new List<IMenuItemClickObserver>();

        public string Title { get; set; }

        public void AddClickObserver(IMenuItemClickObserver i_ClickObserver)
        {
            m_ClickedObserver.Add(i_ClickObserver);
        }

        public void RemoveClickObserver(IMenuItemClickObserver i_ClickObserver)
        {
            m_ClickedObserver.Remove(i_ClickObserver);
        }

        public void PerformClick()
        {
            OnClicked();
        }

        private void OnClicked()
        {
            foreach (IMenuItemClickObserver clickedObserver in m_ClickedObserver)
            {
                clickedObserver.ReportClick(Title);
            }
        }
    }
}
