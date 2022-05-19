namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class InterfaceMenu : IMenuItemClickObserver
    {
        private readonly MainMenu m_MainMenu = new MainMenu("Interfaces Main Menu");

        public InterfaceMenu()
        {
            MainMenu currentMenu;
            MenuItem currentItem;

            currentMenu = m_MainMenu.CreateSubMenu(Data.SubMenu1);
            currentItem = currentMenu.CreateItem(Data.TimeItem);
            currentItem.AddClickObserver(this as IMenuItemClickObserver);
            currentItem = currentMenu.CreateItem(Data.DateItem);
            currentItem.AddClickObserver(this as IMenuItemClickObserver);

            currentMenu = m_MainMenu.CreateSubMenu(Data.SubMenu2);
            currentItem = currentMenu.CreateItem(Data.CountSpacesItem);
            currentItem.AddClickObserver(this as IMenuItemClickObserver);
            currentItem = currentMenu.CreateItem(Data.VersionItem);
            currentItem.AddClickObserver(this as IMenuItemClickObserver);
        }

        public void InitiateMenu()
        {
            m_MainMenu.Initiate();
        }

        public void ReportClick(string i_SelectedItem)
        {
            if (i_SelectedItem.Equals(Data.TimeItem))
            {
                Data.ShowTime();
            }
            else if (i_SelectedItem.Equals(Data.DateItem))
            {
                Data.ShowDate();
            }
            else if (i_SelectedItem.Equals(Data.CountSpacesItem))
            {
                Data.CountSpaces();
            }
            else if (i_SelectedItem.Equals(Data.VersionItem))
            {
                Data.ShowVersion();
            }
        }
    }
}
