namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;

    class DelegateMenu
    {
        private readonly MainMenu m_MainMenu = new MainMenu("Delegates Main Menu");

        public DelegateMenu()
        {
            MainMenu currentMenu;
            MenuItem currentItem;

            currentMenu = m_MainMenu.CreateSubMenu(Data.SubMenu1);
            currentItem = currentMenu.CreateItem(Data.TimeItem);
            currentItem.m_ClickedInvoker += Data.ShowTime;
            currentItem = currentMenu.CreateItem(Data.DateItem);
            currentItem.m_ClickedInvoker += Data.ShowDate;

            currentMenu = m_MainMenu.CreateSubMenu(Data.SubMenu2);
            currentItem = currentMenu.CreateItem(Data.CountSpacesItem);
            currentItem.m_ClickedInvoker += Data.CountSpaces;
            currentItem = currentMenu.CreateItem(Data.VersionItem);
            currentItem.m_ClickedInvoker += Data.ShowVersion;
        }

        public void InitiateMenu()
        {
            m_MainMenu.Initiate();
        }
    }
}
