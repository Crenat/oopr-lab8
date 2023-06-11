private void toolbar1_Buttonclick(object sender,
System.Windows.Forms.Toolbarbuttonclickeventargs e)
{
    int buttonnumber = toolbar1.Buttons.Indexof(e.Button);
    switch (buttonnumber)
    {
        case 0:
        Openfiledialog openfiledialog1 = new Openfiledialog();
        openfiledialog1.Showdialog();
        //код, що показує, що робити з відкритим файлом
        textbox1.Text = "Відкриття Файлу!";
        break;
        case 1:
        Savefiledialog savefiledialog1 = new Savefiledialog();
        savefiledialog1.Showdialog();
        //код, що аналізує результат операції збереження файлу
        textbox1.Text = "Збереження Файлу!";
        break;
        default:
        Colordialog colordialog1 = new Colordialog();
        if (colordialog1.Showdialog()== Dialogresult.OK)
        this.textbox1.Backcolor =colordialog1.Color;
        break;
    }
}

private System.Windows.Forms.Toolbar toolbar1;
private System.Windows.Forms.Imagelist imagelist1;
private System.Windows.Forms.Toolbarbutton
toolbarbutton1;
private System.Windows.Forms.Toolbarbutton
toolbarbutton2;
private System.Windows.Forms.Toolbarbutton
toolbarbutton3;
this.toolbar1 = new System.Windows.Forms.Toolbar();
this.imagelist1 = new
System.Windows.Forms.Imagelist(this.components);
this.toolbarbutton1 = new
System.Windows.Forms.Toolbarbutton();
this.toolbarbutton2 = new
System.Windows.Forms.Toolbarbutton();
this.toolbarbutton3 = new
System.Windows.Forms.Toolbarbutton();
// toolbar1
this.toolbar1.Buttons.Addrange(new
System.Windows.Forms.Toolbarbutton[]
{this.toolbarbutton1,
this.toolbarbutton2,this.toolbarbutton3});
this.toolbar1.Dropdownarrows = true;
this.toolbar1.Imagelist = this.imagelist1;
this.toolbar1.Name = "toolbar1";
this.toolbar1.Showtooltips = true;
this.toolbar1.Size = new System.Drawing.Size(432,
42);
this.toolbar1.Tabindex = 1;
this.toolbar1.Buttonclick +=
new
System.Windows.Forms.Toolbarbuttonclickeventhandler(
this.toolbar1_Buttonclick);
// toolbarbutton1
this.toolbarbutton1.Imageindex = 0;
this.toolbarbutton1.Text = "Openfile";
this.toolbarbutton1.Tooltiptext =
"Діалогове вікно відкриття файлу";
