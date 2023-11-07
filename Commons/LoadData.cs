using Book_App.Database;
using Bunifu.UI.WinForms;

namespace Book_App.Commons
{
    public class LoadData
    {
       public static void LoadDropDown(string table,BunifuDropdown bunifuDropdown)
       {
            bunifuDropdown.DataSource = DBUtil.Instance.GetList(table);
            bunifuDropdown.DisplayMember = "name";
            bunifuDropdown.ValueMember = "id";
            bunifuDropdown.SelectedIndex = -1;
            bunifuDropdown.SelectedIndex = -1;

        }
    }
}
