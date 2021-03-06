﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace WTS.UITest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// OpenVisualStudio - Use 'OpenVisualStudioParams' to pass parameters into this method.
        /// </summary>
        public void OpenVisualStudio()
        {
            #region Variable Declarations
            WinComboBox uIOpenComboBox = this.UIRunWindow.UIItemWindow.UIOpenComboBox;
            WinEdit uIOpenEdit = this.UIRunWindow.UIItemWindow1.UIOpenEdit;
            #endregion

            // Press keyboard shortcut keys 'Windows + r'
            Keyboard.SendKeys(this.OpenVisualStudioParams.SendKeys, ModifierKeys.Windows);

            // Select 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe' in 'Open:' combo box
            uIOpenComboBox.EditableItem = this.OpenVisualStudioParams.UIOpenComboBoxEditableItem;

            // Type '{Enter}' in 'Open:' text box
            Keyboard.SendKeys(uIOpenEdit, this.OpenVisualStudioParams.UIOpenEditSendKeys, ModifierKeys.None);
        }
        
        /// <summary>
        /// CreateNewProject
        /// </summary>
        public void CreateNewProject()
        {
            #region Variable Declarations
            WpfMenuItem uIProjectMenuItem = this.UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIFileMenuItem.UINewMenuItem.UIProjectMenuItem;
            WpfText uIUwpTemplatesbasedAppText = this.UINewProjectWindow.UIM_vsExtnsExplorerCtlCustom.UIExtensionsTable.UIUwpTemplatesbasedAppDataItem.UIItemCell.UIUwpTemplatesbasedAppText;
            WpfButton uIOKButton = this.UINewProjectWindow.UIOKButton;
            #endregion

            // Click 'File' -> 'New' -> 'Project...' menu item
            Mouse.Click(uIProjectMenuItem, new Point(48, 9));

            // Click 'Uwp Templates based App (vs2017 dev-nightly)' label
            Mouse.Click(uIUwpTemplatesbasedAppText, new Point(70, 1));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(34, 10));
        }
        
        /// <summary>
        /// SelectBasicBlank
        /// </summary>
        public void SelectBasicBlank()
        {
            #region Variable Declarations
            WpfButton uINextButton = this.UIUWPCommunityTemplateWindow.UINextButton;
            #endregion

            // Click 'Next >' button
            Mouse.Click(uINextButton, new Point(35, 12));

            // Click 'Next >' button
            Mouse.Click(uINextButton, new Point(31, 15));
        }
        
        #region Properties
        public virtual OpenVisualStudioParams OpenVisualStudioParams
        {
            get
            {
                if ((this.mOpenVisualStudioParams == null))
                {
                    this.mOpenVisualStudioParams = new OpenVisualStudioParams();
                }
                return this.mOpenVisualStudioParams;
            }
        }
        
        public UIRunWindow UIRunWindow
        {
            get
            {
                if ((this.mUIRunWindow == null))
                {
                    this.mUIRunWindow = new UIRunWindow();
                }
                return this.mUIRunWindow;
            }
        }
        
        public UIStartPageMicrosoftViWindow UIStartPageMicrosoftViWindow
        {
            get
            {
                if ((this.mUIStartPageMicrosoftViWindow == null))
                {
                    this.mUIStartPageMicrosoftViWindow = new UIStartPageMicrosoftViWindow();
                }
                return this.mUIStartPageMicrosoftViWindow;
            }
        }
        
        public UINewProjectWindow UINewProjectWindow
        {
            get
            {
                if ((this.mUINewProjectWindow == null))
                {
                    this.mUINewProjectWindow = new UINewProjectWindow();
                }
                return this.mUINewProjectWindow;
            }
        }
        
        public UIUWPCommunityTemplateWindow UIUWPCommunityTemplateWindow
        {
            get
            {
                if ((this.mUIUWPCommunityTemplateWindow == null))
                {
                    this.mUIUWPCommunityTemplateWindow = new UIUWPCommunityTemplateWindow();
                }
                return this.mUIUWPCommunityTemplateWindow;
            }
        }
        #endregion
        
        #region Fields
        private OpenVisualStudioParams mOpenVisualStudioParams;
        
        private UIRunWindow mUIRunWindow;
        
        private UIStartPageMicrosoftViWindow mUIStartPageMicrosoftViWindow;
        
        private UINewProjectWindow mUINewProjectWindow;
        
        private UIUWPCommunityTemplateWindow mUIUWPCommunityTemplateWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OpenVisualStudio'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class OpenVisualStudioParams
    {
        
        #region Fields
        /// <summary>
        /// Press keyboard shortcut keys 'Windows + r'
        /// </summary>
        public string SendKeys = "r";
        
        /// <summary>
        /// Select 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe' in 'Open:' combo box
        /// </summary>
        public string UIOpenComboBoxEditableItem = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\devenv" +
            ".exe";
        
        /// <summary>
        /// Type '{Enter}' in 'Open:' text box
        /// </summary>
        public string UIOpenEditSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIRunWindow : WinWindow
    {
        
        public UIRunWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Run";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "12298";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIOpenComboBox
        {
            get
            {
                if ((this.mUIOpenComboBox == null))
                {
                    this.mUIOpenComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIOpenComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Open:";
                    this.mUIOpenComboBox.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIOpenComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinEdit UIOpenEdit
        {
            get
            {
                if ((this.mUIOpenEdit == null))
                {
                    this.mUIOpenEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIOpenEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Open:";
                    this.mUIOpenEdit.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIOpenEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIStartPageMicrosoftViWindow : WpfWindow
    {
        
        public UIStartPageMicrosoftViWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Start Page - Microsoft Visual Studio";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIMenuBarMenuBar UIMenuBarMenuBar
        {
            get
            {
                if ((this.mUIMenuBarMenuBar == null))
                {
                    this.mUIMenuBarMenuBar = new UIMenuBarMenuBar(this);
                }
                return this.mUIMenuBarMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuBarMenuBar mUIMenuBarMenuBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMenuBarMenuBar : WpfControl
    {
        
        public UIMenuBarMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ControlType] = "MenuBar";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "MenuBar";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIFileMenuItem UIFileMenuItem
        {
            get
            {
                if ((this.mUIFileMenuItem == null))
                {
                    this.mUIFileMenuItem = new UIFileMenuItem(this);
                }
                return this.mUIFileMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIFileMenuItem mUIFileMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIFileMenuItem : WpfMenuItem
    {
        
        public UIFileMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfMenuItem.PropertyNames.Name] = "File";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UINewMenuItem UINewMenuItem
        {
            get
            {
                if ((this.mUINewMenuItem == null))
                {
                    this.mUINewMenuItem = new UINewMenuItem(this);
                }
                return this.mUINewMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UINewMenuItem mUINewMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINewMenuItem : WpfMenuItem
    {
        
        public UINewMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfMenuItem.PropertyNames.Name] = "New";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfMenuItem UIProjectMenuItem
        {
            get
            {
                if ((this.mUIProjectMenuItem == null))
                {
                    this.mUIProjectMenuItem = new WpfMenuItem(this);
                    #region Search Criteria
                    this.mUIProjectMenuItem.SearchProperties[WpfMenuItem.PropertyNames.Name] = "Project...";
                    this.mUIProjectMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIProjectMenuItem.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIProjectMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfMenuItem mUIProjectMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINewProjectWindow : WpfWindow
    {
        
        public UINewProjectWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "New Project";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("New Project");
            #endregion
        }
        
        #region Properties
        public UIM_vsExtnsExplorerCtlCustom UIM_vsExtnsExplorerCtlCustom
        {
            get
            {
                if ((this.mUIM_vsExtnsExplorerCtlCustom == null))
                {
                    this.mUIM_vsExtnsExplorerCtlCustom = new UIM_vsExtnsExplorerCtlCustom(this);
                }
                return this.mUIM_vsExtnsExplorerCtlCustom;
            }
        }
        
        public WpfButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_OK";
                    this.mUIOKButton.WindowTitles.Add("New Project");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private UIM_vsExtnsExplorerCtlCustom mUIM_vsExtnsExplorerCtlCustom;
        
        private WpfButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIM_vsExtnsExplorerCtlCustom : WpfCustom
    {
        
        public UIM_vsExtnsExplorerCtlCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.VSExtensionsExplorerCtl";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "m_vsExtnsExplorerCtl";
            this.WindowTitles.Add("New Project");
            #endregion
        }
        
        #region Properties
        public UIExtensionsTable UIExtensionsTable
        {
            get
            {
                if ((this.mUIExtensionsTable == null))
                {
                    this.mUIExtensionsTable = new UIExtensionsTable(this);
                }
                return this.mUIExtensionsTable;
            }
        }
        #endregion
        
        #region Fields
        private UIExtensionsTable mUIExtensionsTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIExtensionsTable : WpfTable
    {
        
        public UIExtensionsTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTable.PropertyNames.AutomationId] = "lvw_Extensions";
            this.WindowTitles.Add("New Project");
            #endregion
        }
        
        #region Properties
        public UIUwpTemplatesbasedAppDataItem UIUwpTemplatesbasedAppDataItem
        {
            get
            {
                if ((this.mUIUwpTemplatesbasedAppDataItem == null))
                {
                    this.mUIUwpTemplatesbasedAppDataItem = new UIUwpTemplatesbasedAppDataItem(this);
                }
                return this.mUIUwpTemplatesbasedAppDataItem;
            }
        }
        #endregion
        
        #region Fields
        private UIUwpTemplatesbasedAppDataItem mUIUwpTemplatesbasedAppDataItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIUwpTemplatesbasedAppDataItem : WpfControl
    {
        
        public UIUwpTemplatesbasedAppDataItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ControlType] = "DataItem";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Uwp Templates based App (vs2017 dev-nightly)";
            this.WindowTitles.Add("New Project");
            #endregion
        }
        
        #region Properties
        public UIItemCell UIItemCell
        {
            get
            {
                if ((this.mUIItemCell == null))
                {
                    this.mUIItemCell = new UIItemCell(this);
                }
                return this.mUIItemCell;
            }
        }
        #endregion
        
        #region Fields
        private UIItemCell mUIItemCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemCell : WpfCell
    {
        
        public UIItemCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Name";
            this.WindowTitles.Add("New Project");
            #endregion
        }
        
        #region Properties
        public WpfText UIUwpTemplatesbasedAppText
        {
            get
            {
                if ((this.mUIUwpTemplatesbasedAppText == null))
                {
                    this.mUIUwpTemplatesbasedAppText = new WpfText(this);
                    #region Search Criteria
                    this.mUIUwpTemplatesbasedAppText.SearchProperties[WpfText.PropertyNames.Name] = "Uwp Templates based App (vs2017 dev-nightly)";
                    this.mUIUwpTemplatesbasedAppText.WindowTitles.Add("New Project");
                    #endregion
                }
                return this.mUIUwpTemplatesbasedAppText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUIUwpTemplatesbasedAppText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIUWPCommunityTemplateWindow : WpfWindow
    {
        
        public UIUWPCommunityTemplateWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "UWP Community Templates";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("UWP Community Templates");
            #endregion
        }
        
        #region Properties
        public WpfButton UINextButton
        {
            get
            {
                if ((this.mUINextButton == null))
                {
                    this.mUINextButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUINextButton.SearchProperties[WpfButton.PropertyNames.Name] = "Next >";
                    this.mUINextButton.WindowTitles.Add("UWP Community Templates");
                    #endregion
                }
                return this.mUINextButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUINextButton;
        #endregion
    }
}
