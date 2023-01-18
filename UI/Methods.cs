using Entities.Enums;

namespace UI;

internal static class Methods
{
    internal static void ComboBoxDoldur(ComboBox cmb)
    {
        cmb.DataSource = Enum.GetNames(typeof(Gender)).ToList();
        cmb.SelectedIndex = -1;
    }


}