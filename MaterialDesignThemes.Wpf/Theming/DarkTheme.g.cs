using System.Windows.Media;

namespace MaterialDesignThemes.Wpf.Theming;

partial class DarkTheme
{
    public DarkTheme()
    {
        Background = Color.FromArgb(0xFF, 0x0, 0x0, 0x0);
        Button.FlatClick = Color.FromArgb(0x19, 0x75, 0x75, 0x75);
        Button.FlatRipple = Color.FromArgb(0xFF, 0xB6, 0xB6, 0xB6);
        Card.Background = Color.FromArgb(0xFF, 0x42, 0x42, 0x42);
        CheckBox.Disabled = Color.FromArgb(0xFF, 0x64, 0x70, 0x76);
        CheckBox.Off = Color.FromArgb(0x89, 0xFF, 0xFF, 0xFF);
        Chip.Background = Color.FromArgb(0xFF, 0x2E, 0x3C, 0x43);
        DataGrid.ColumnHeaderForeground = Color.FromArgb(0xBC, 0xFF, 0xFF, 0xFF);
        DataGrid.RowHoverBackground = Color.FromArgb(0x14, 0xFF, 0xFF, 0xFF);
        Foreground = Color.FromArgb(0xDD, 0xFF, 0xFF, 0xFF);
        LightForeground = Color.FromArgb(0x89, 0xFF, 0xFF, 0xFF);
        SnackBar.Background = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
        SnackBar.MouseOver = Color.FromArgb(0xFF, 0xB9, 0xB9, 0xBD);
        SnackBar.Ripple = Color.FromArgb(0xFF, 0x49, 0x49, 0x49);
        TextBox.Border = Color.FromArgb(0x89, 0xFF, 0xFF, 0xFF);
        TextBox.DisabledBackground = Color.FromArgb(0xD, 0xFF, 0xFF, 0xFF);
        TextBox.FilledBackground = Color.FromArgb(0x1A, 0xFF, 0xFF, 0xFF);
        TextBox.HoverBackground = Color.FromArgb(0x1F, 0xFF, 0xFF, 0xFF);
        TextBox.OutlineBorder = Color.FromArgb(0xBC, 0xFF, 0xFF, 0xFF);
        TextBox.OutlineInactiveBorder = Color.FromArgb(0x29, 0xFF, 0xFF, 0xFF);
        ToolBar.Background = Color.FromArgb(0xFF, 0x21, 0x21, 0x21);
        ToolBar.Item.Background = Color.FromArgb(0xFF, 0xE0, 0xE0, 0xE0);
        ToolBar.Item.Foreground = Color.FromArgb(0xFF, 0x61, 0x61, 0x61);
        ToolTip.Background = Color.FromArgb(0xFF, 0xEE, 0xEE, 0xEE);
        ValidationError = Color.FromArgb(0xFF, 0xCF, 0x66, 0x79);
    }
}
