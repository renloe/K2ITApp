using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Management;

namespace K2ITApp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string serviceTag = string.Empty;
        
        public MainWindow()
        {
            InitializeComponent();
            documentReader.Height = 400;            
        }      


        private void InstallSoftware_Click(object sender, MouseButtonEventArgs e)
        {
            StackPanel source = sender as StackPanel;
            string softwareToInstall = source.Name;

            if (softwareToInstall == "SevenZip")
            {
                LoadDocumentReader("SevenZip_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }            
            else if (softwareToInstall == "Acrobat9")
            {
                LoadDocumentReader("Acrobat_9_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }
            else if (softwareToInstall == "Acrobat10")
            {
                LoadDocumentReader("Acrobat_10_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }
            else if (softwareToInstall == "AdobeReader")
            {
                LoadDocumentReader("Adobe_Reader_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }

            else if (softwareToInstall == "AdvancedScanSoftware")
            {
                LoadDocumentReader("AdvancedScanSoftware_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }

            else if (softwareToInstall == "GoogleChrome")
            {
                LoadDocumentReader("GoogleChrome_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }

            else if (softwareToInstall == "MSProject2010")
            {
                LoadDocumentReader("MSProject2010_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }

            else if (softwareToInstall == "NAVRoleTailoredClient")
            {
                LoadDocumentReader("NAV_RoleTailoredClient_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }

            else if (softwareToInstall == "Silverlight")
            {
                LoadDocumentReader("Silverlight_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }   
            
                else if (softwareToInstall == "dotNet4")
            {
                LoadDocumentReader("dotNet4_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(softwareToInstall);
            }   
        }

        private void InstallPrinter_Click(object sender, MouseButtonEventArgs e)
        {
            StackPanel source = sender as StackPanel;
            string printerName = source.Name;


            if (printerName == "Brother_8460DN")
            {
                LoadDocumentReader("Brother8460_Printer_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(printerName);
            }
            else if (printerName == "Brother_8480DN")
            {
                LoadDocumentReader("Brother8480_Printer_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(printerName);
            }
            else if (printerName == "HP_3525")
            {
                 LoadDocumentReader("HP_Printer_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(printerName);
            }
            else if (printerName == "Canon_8350Cdn")
            {
                LoadDocumentReader("CanonMF8350_Printer_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(printerName);
            }
            else if (printerName == "Brother_9320DN")
            {
                LoadDocumentReader("Brother9320_Printer_Help.xaml");
                documentReader.Visibility = Visibility.Visible;
                LaunchInstaller(printerName);
            }
        }

        private void LoadDocumentReader(string documentName)
        {
            documentName = @".\HelpFiles\" + documentName;
            documentReader.Document = (FlowDocument)XamlReader.Load(File.OpenRead(documentName));
        }

        private void LaunchInstaller(string softwareToInstall)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            #region Applications

            #region 7zip
            if (softwareToInstall == "SevenZip")
            {
                startInfo.FileName = @".\Applications\7zip\7z920-x64.msi";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region .NET 4 Framework - Full
            if (softwareToInstall == "dotNet4")
            {
                startInfo.FileName = @".\Applications\NetFrameworkFull\dotNetFx40_Full_x86_x64.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion
            
            #region Acrobat 9
            if (softwareToInstall == "Acrobat9")
            {
                startInfo.FileName = @".\Applications\AdobeAcrobat9\AutoPlay.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region Acrobat 10
            else if (softwareToInstall == "Acrobat10")
            {
                startInfo.FileName = @".\Applications\AdobeAcrobatX\setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region Advance Scan Software
            else if (softwareToInstall == "AdvancedScanSoftware")
            {
                startInfo.FileName = @".\Applications\AdvancedScanSoftware\AdvancedScantoPDFFree.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region AdobeReader11
            else if (softwareToInstall == "AdobeReader")
            {
                startInfo.FileName = @".\Applications\AdobeReader\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled" ,MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region Goolge Chrome
            else if (softwareToInstall == "GoogleChrome")
            {
                startInfo.FileName = @".\Applications\GoogleChrome\ChromeStandaloneSetup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region MS Project 2010
            else if (softwareToInstall == "MSProject2010")
            {
                startInfo.FileName = @".\Applications\MSProject2010x64\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region NAV Role Tailored Client
            else if (softwareToInstall == "NAVRoleTailoredClient")
            {
                startInfo.FileName = @".\Applications\NAV\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled" ,MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

            #region Silverlight
            else if (softwareToInstall == "Silverlight")
            {
                startInfo.FileName = @".\Applications\Silverlight\silverlight.msi";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            #endregion

          


            #endregion

            #region Printers

            else if (softwareToInstall == "Brother_8460DN")
            {
                startInfo.FileName = @".\PrinterDrivers\Brother8460DN\MFC-8460N\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            
            else if (softwareToInstall == "Brother_8480DN")
            {
                startInfo.FileName = @".\PrinterDrivers\Brother8480DN\MFC-8480DN\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }

            else if (softwareToInstall == "Brother_9320DN")
            {
                startInfo.FileName = @".\PrinterDrivers\BrotherMFC9320DN\mflpro\MFC-9320CW\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }               

            else if (softwareToInstall == "HP_3525")
            {
                startInfo.FileName = @".\PrinterDrivers\HP3525\Install.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }

            else if (softwareToInstall == "Canon_8350Cdn")
            {
                startInfo.FileName = @".\PrinterDrivers\CanonMF8350Cdn\Setup.exe";
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Operation Cancelled", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }

            #endregion
        }
      

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            documentReader.Visibility = Visibility.Collapsed;
        }       

        private void tbClose_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeWindow_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }       

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();               
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select SerialNumber from Win32_Bios");
            ManagementObjectCollection collection = searcher.Get();            

            foreach (var obj in collection)
            {
                foreach (var data in obj.Properties)
                {
                    serviceTag = data.Value.ToString();
                    tbServiceTag.Text = "Service Tag: " + serviceTag;
                }
            }
        }

        private void tbServiceTag_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (serviceTag != string.Empty)
	        {
                // Link for Dell Warranty Information
                string urlForServiceTag = @"http://support.dell.com/support/topics/global.aspx/support/my_systems_info/details?c=us&l=en&s=gen&ServiceTag=" + serviceTag;
                Process.Start("IEXPLORE.EXE", urlForServiceTag);               
	        }            
        }

        private void Global_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Global_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }       
    }

}
