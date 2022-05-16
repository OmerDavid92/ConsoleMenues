namespace Ex04.Menus.Delegates
{
    public delegate void ClickedInvoker();

    public class MenuItem
    {
        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }

        public event ClickedInvoker m_ClickedInvoker;

        public string Title { get; private set; }

        public void PerformClick()
        {
            OnClicked();
        }

        private void OnClicked()
        {
            if (m_ClickedInvoker != null)
            {
                m_ClickedInvoker.Invoke();
            }
        }
    }
}
