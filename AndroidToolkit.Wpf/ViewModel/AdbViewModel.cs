﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using AndroidToolkit.Infrastructure.Helpers;
using AndroidToolkit.Infrastructure.Tools;
using AndroidToolkit.Wpf.Presentation;
using AndroidToolkit.Wpf.Presentation.Converters;
using AndroidToolkit.Wpf.Presentation.Presenter;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro;

namespace AndroidToolkit.Wpf.ViewModel
{
    public class AdbViewModel : ViewModelBase
    {
        public AdbViewModel()
        {
            ThreeTextCommandParameters = new ThreeTextCommandParameters();
            FiveTextCommandParameters = new FiveTextCommandParameters();
            InstallTwoCommandParameters = new TwoCommandParameters();
            UninstallTwoCommandParameters = new TwoCommandParameters();
            UiParameters = new UIParameters();
            ExecuteSingleCommandParameters = new TwoCommandParameters();
            CopyCommandParameters = new ThreeTextCommandParameters();
            MoveCommandParameters = new ThreeTextCommandParameters();
            DeleteCommandParameters = new TwoCommandParameters();
            SideloadParameters = new TwoCommandParameters();
            ExecuteCommandsParameters = new ExecuteCommandParameters();
            BackupParameters = new BackupParameters();
            RestoreParameters = new TwoCommandParameters();
        }

        #region Commands


        #region Reboot

        private RelayCommand<SingleCommandParameters> _rebootCommand;

        public RelayCommand<SingleCommandParameters> RebootCommand
        {
            get
            {
                return _rebootCommand ?? (_rebootCommand = new RelayCommand<SingleCommandParameters>(AdbPresenter.ExecuteReboot));

            }
            set
            {
                if (_rebootCommand != value)
                {
                    RaisePropertyChanging(() => this.RebootCommand);
                    _rebootCommand = value;
                    RaisePropertyChanged(() => this.RebootCommand);
                }
            }
        }

        private RelayCommand<SingleCommandParameters> _rebootRecoveryCommand;

        public RelayCommand<SingleCommandParameters> RebootRecoveryCommand
        {
            get
            {
                return _rebootRecoveryCommand ?? (_rebootRecoveryCommand = new RelayCommand<SingleCommandParameters>(AdbPresenter.ExecuteRebootRecovery));
            }
            set
            {
                if (_rebootRecoveryCommand != value)
                {
                    RaisePropertyChanging(() => this.RebootRecoveryCommand);
                    _rebootRecoveryCommand = value;
                    RaisePropertyChanged(() => this.RebootRecoveryCommand);
                }
            }
        }

        private RelayCommand<SingleCommandParameters> _rebootBootloaderCommand;

        public RelayCommand<SingleCommandParameters> RebootBootloaderCommand
        {
            get
            {
                return _rebootBootloaderCommand ?? (_rebootBootloaderCommand = new RelayCommand<SingleCommandParameters>(AdbPresenter.ExecuteRebootBootloader));
            }
            set
            {
                if (_rebootBootloaderCommand != value)
                {
                    RaisePropertyChanging(() => this.RebootBootloaderCommand);
                    _rebootBootloaderCommand = value;
                    RaisePropertyChanged(() => this.RebootBootloaderCommand);
                }
            }
        }

        #endregion

        private RelayCommand<TextBlock> _prepareCommand;

        public RelayCommand<TextBlock> PrepareCommand
        {
            get
            {
                return _prepareCommand ?? (_prepareCommand = new RelayCommand<TextBlock>(AdbPresenter.ExecutePrepare));

            }
            set
            {
                if (_prepareCommand != value)
                {
                    RaisePropertyChanging(() => this.PrepareCommand);
                    _prepareCommand = value;
                    RaisePropertyChanged(() => this.PrepareCommand);
                }
            }
        }


        private RelayCommand<ThreeTextCommandParameters> _pushCommand;

        public RelayCommand<ThreeTextCommandParameters> PushCommand
        {
            get
            {
                return _pushCommand ?? (_pushCommand = new RelayCommand<ThreeTextCommandParameters>(AdbPresenter.ExecutePush));
            }
            set
            {
                if (_pushCommand != value)
                {
                    RaisePropertyChanging(() => this.PushCommand);
                    _pushCommand = value;
                    RaisePropertyChanged(() => this.PushCommand);
                }
            }
        }

        private RelayCommand<FiveTextCommandParameters> _pullCommand;

        public RelayCommand<FiveTextCommandParameters> PullCommand
        {
            get
            {
                return _pullCommand ?? (_pullCommand = new RelayCommand<FiveTextCommandParameters>(AdbPresenter.ExecutePull));
            }
            set
            {
                if (_pullCommand != value)
                {
                    RaisePropertyChanging(() => this.PullCommand);
                    _pullCommand = value;
                    RaisePropertyChanged(() => this.PullCommand);
                }
            }
        }

        private RelayCommand<ThreeTextCommandParameters> _copyCommand;

        public RelayCommand<ThreeTextCommandParameters> CopyCommand
        {
            get
            {
                return _copyCommand ?? (_copyCommand = new RelayCommand<ThreeTextCommandParameters>(AdbPresenter.ExecuteCopy));
            }
            set
            {
                if (_copyCommand != value)
                {
                    RaisePropertyChanging(() => this.CopyCommand);
                    _copyCommand = value;
                    RaisePropertyChanged(() => this.CopyCommand);
                }
            }
        }

        private RelayCommand<ThreeTextCommandParameters> _moveCommand;

        public RelayCommand<ThreeTextCommandParameters> MoveCommand
        {
            get
            {
                return _moveCommand ?? (_moveCommand = new RelayCommand<ThreeTextCommandParameters>(AdbPresenter.ExecuteMove));
            }
            set
            {
                if (_moveCommand != value)
                {
                    RaisePropertyChanging(() => this.MoveCommand);
                    _moveCommand = value;
                    RaisePropertyChanged(() => this.MoveCommand);
                }
            }
        }

        private RelayCommand<TwoCommandParameters> _deleteCommand;

        public RelayCommand<TwoCommandParameters> DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new RelayCommand<TwoCommandParameters>(AdbPresenter.ExecuteDelete));
            }
            set
            {
                if (_deleteCommand != value)
                {
                    RaisePropertyChanging(() => this.DeleteCommand);
                    _deleteCommand = value;
                    RaisePropertyChanged(() => this.DeleteCommand);
                }
            }
        }

        private RelayCommand<TwoCommandParameters> _sideloadCommand;

        public RelayCommand<TwoCommandParameters> SideloadCommand
        {
            get
            {
                return _sideloadCommand ?? (_sideloadCommand = new RelayCommand<TwoCommandParameters>(AdbPresenter.ExecuteSideload));
            }
            set
            {
                if (_sideloadCommand != value)
                {
                    RaisePropertyChanging(() => this.SideloadCommand);
                    _sideloadCommand = value;
                    RaisePropertyChanged(() => this.SideloadCommand);
                }
            }
        }

        private RelayCommand<UIParameters> _logcatCommand;

        public RelayCommand<UIParameters> LogcatCommand
        {
            get
            {
                return _logcatCommand ?? (_logcatCommand = new RelayCommand<UIParameters>(AdbPresenter.ExecuteLogcat));
            }
            set
            {
                if (_logcatCommand != value)
                {
                    RaisePropertyChanging(() => this.LogcatCommand);
                    _logcatCommand = value;
                    RaisePropertyChanged(() => this.LogcatCommand);
                }
            }
        }


        private RelayCommand<TwoCommandParameters> _installCommand;

        public RelayCommand<TwoCommandParameters> InstallCommand
        {
            get
            {
                return _installCommand ?? (_installCommand = new RelayCommand<TwoCommandParameters>(AdbPresenter.ExecuteInstall));
            }
            set
            {
                if (_installCommand != value)
                {
                    RaisePropertyChanging(() => this.InstallCommand);
                    _installCommand = value;
                    RaisePropertyChanged(() => this.InstallCommand);
                }
            }
        }

        private RelayCommand<TwoCommandParameters> _uninstallCommand;

        public RelayCommand<TwoCommandParameters> UninstallCommand
        {
            get
            {
                return _uninstallCommand ?? (_uninstallCommand = new RelayCommand<TwoCommandParameters>(AdbPresenter.ExecuteUninstall));

            }
            set
            {
                if (_uninstallCommand != value)
                {
                    RaisePropertyChanging(() => this.UninstallCommand);
                    _uninstallCommand = value;
                    RaisePropertyChanged(() => this.UninstallCommand);
                }
            }
        }

        private RelayCommand<UIParameters> _listAppsCommand;

        public RelayCommand<UIParameters> ListAppsCommand
        {
            get
            {
                return _listAppsCommand ?? (_listAppsCommand = new RelayCommand<UIParameters>(AdbPresenter.ExecuteListApps));
            }
            set
            {
                if (_listAppsCommand != value)
                {
                    RaisePropertyChanging(() => this.ListAppsCommand);
                    _listAppsCommand = value;
                    RaisePropertyChanged(() => this.ListAppsCommand);
                }
            }
        }

        private RelayCommand<UIParameters> _listDevicesCommand;

        public RelayCommand<UIParameters> ListDevicesCommand
        {
            get
            {
                return _listDevicesCommand ?? (_listDevicesCommand = new RelayCommand<UIParameters>(AdbPresenter.ExecuteListDevices));
            }
            set
            {
                if (_listDevicesCommand != value)
                {
                    RaisePropertyChanging(() => this.ListDevicesCommand);
                    _listDevicesCommand = value;
                    RaisePropertyChanged(() => this.ListDevicesCommand);
                }
            }
        }

        #region Backup

        private RelayCommand<BackupParameters> _backupCommand;

        public RelayCommand<BackupParameters> BackupCommand
        {
            get
            {
                return _backupCommand ?? (_backupCommand = new RelayCommand<BackupParameters>(AdbPresenter.ExecuteBackup));
            }
            set
            {
                if (_backupCommand != value)
                {
                    RaisePropertyChanging(() => this.BackupCommand);
                    _backupCommand = value;
                    RaisePropertyChanged(() => this.BackupCommand);
                }
            }
        }

        private RelayCommand<TwoCommandParameters> _restoreCommand;
        public RelayCommand<TwoCommandParameters> RestoreCommand
        {
            get
            {
                return _restoreCommand ?? (_restoreCommand = new RelayCommand<TwoCommandParameters>(AdbPresenter.ExecuteRestore));
            }
            set
            {
                if (_restoreCommand != value)
                {
                    RaisePropertyChanging(() => this.RestoreCommand);
                    _restoreCommand = value;
                    RaisePropertyChanged(() => this.RestoreCommand);
                }
            }
        }

        #endregion


        #region Execute
        private RelayCommand<TwoCommandParameters> _executeSingleCommand;

        public RelayCommand<TwoCommandParameters> ExecuteSingleCommand
        {
            get { return _executeSingleCommand ?? (_executeSingleCommand = new RelayCommand<TwoCommandParameters>(AdbPresenter.ExecuteSingleCommand)); }
            set
            {
                if (_executeSingleCommand != value)
                {
                    RaisePropertyChanging(() => this.ExecuteSingleCommand);
                    _executeSingleCommand = value;
                    RaisePropertyChanged(() => this.ExecuteSingleCommand);
                }
            }
        }

        private RelayCommand<ExecuteCommandParameters> _executeCommand;

        public RelayCommand<ExecuteCommandParameters> ExecuteCommands
        {
            get { return _executeCommand ?? (_executeCommand = new RelayCommand<ExecuteCommandParameters>(AdbPresenter.Execute)); }
            set
            {
                if (_executeCommand != value)
                {
                    RaisePropertyChanging(() => this.ExecuteCommands);
                    _executeCommand = value;
                    RaisePropertyChanged(() => this.ExecuteCommands);
                }
            }
        }
        #endregion

        #region UICommands

        private RelayCommand<TextBlock> _clearImmediateCommand;

        public RelayCommand<TextBlock> ClearImmediateCommand
        {
            get { return _clearImmediateCommand ?? (_clearImmediateCommand = new RelayCommand<TextBlock>(AdbPresenter.ExecuteClearImmediate)); }
            set
            {
                if (_clearImmediateCommand != value)
                {
                    RaisePropertyChanging(() => this.ClearImmediateCommand);
                    _clearImmediateCommand = value;
                    RaisePropertyChanged(() => this.PrepareCommand);
                }
            }
        }

        private RelayCommand<TextBox> _openFileCommand;

        public RelayCommand<TextBox> OpenFileCommand
        {
            get { return _openFileCommand ?? (_openFileCommand = new RelayCommand<TextBox>(AdbPresenter.OpenFile)); }
            set
            {
                if (_openFileCommand != value)
                {
                    RaisePropertyChanging(() => this.ClearImmediateCommand);
                    _openFileCommand = value;
                    RaisePropertyChanged(() => this.PrepareCommand);
                }
            }
        }

        private RelayCommand<TextBox> _openZipCommand;
        public RelayCommand<TextBox> OpenZipCommand
        {
            get
            {
                return _openZipCommand ?? (_openZipCommand = new RelayCommand<TextBox>((arg) =>
                    {
                        arg.Text = FileDialog.ShowDialog("Android Zip File (.zip)|*.zip", false);
                    }));
            }
            set
            {
                if (_openZipCommand != value)
                {
                    RaisePropertyChanging(() => this.OpenZipCommand);
                    _openZipCommand = value;
                    RaisePropertyChanged(() => this.OpenZipCommand);
                }
            }
        }
        private RelayCommand<TextBox> _openBackupCommand;

        public RelayCommand<TextBox> OpenBackupCommand
        {
            get { return _openBackupCommand ?? (_openBackupCommand = new RelayCommand<TextBox>(AdbPresenter.OpenBackup)); }
            set
            {
                if (_openBackupCommand != value)
                {
                    RaisePropertyChanging(() => this.ClearImmediateCommand);
                    _openBackupCommand = value;
                    RaisePropertyChanged(() => this.PrepareCommand);
                }
            }
        }
        private RelayCommand<TextBox> _openAppCommand;

        public RelayCommand<TextBox> OpenAppCommand
        {
            get { return _openAppCommand ?? (_openAppCommand = new RelayCommand<TextBox>(AdbPresenter.OpenApp)); }
            set
            {
                if (_openAppCommand != value)
                {
                    RaisePropertyChanging(() => this.ClearImmediateCommand);
                    _openAppCommand = value;
                    RaisePropertyChanged(() => this.PrepareCommand);
                }
            }
        }

        private RelayCommand<TextBox> _saveFileCommand;

        public RelayCommand<TextBox> SaveFileCommand
        {
            get { return _saveFileCommand ?? (_saveFileCommand = new RelayCommand<TextBox>(AdbPresenter.SaveFile)); }
            set
            {
                if (_saveFileCommand != value)
                {
                    RaisePropertyChanging(() => this.ClearImmediateCommand);
                    _saveFileCommand = value;
                    RaisePropertyChanged(() => this.PrepareCommand);
                }
            }
        }

        #endregion

        #endregion

        #region Properties

        private ObservableCollection<Accent> _accents;

        public ObservableCollection<Accent> Accents
        {
            get { return _accents ?? (_accents = new ObservableCollection<Accent>(ThemeManager.Accents)); }
            set
            {
                if (_accents != value)
                {
                    RaisePropertyChanging(() => Accents);
                    this._accents = value;
                    RaisePropertyChanged(() => Accents);
                }
            }
        }

        public IEnumerable AdbBackupModes
        {
            get { return typeof(AdbBackupMode).ToList(); }
        }

        public UIParameters UiParameters { get; set; }

        public ThreeTextCommandParameters CopyCommandParameters { get; set; }

        public ThreeTextCommandParameters MoveCommandParameters { get; set; }

        public TwoCommandParameters DeleteCommandParameters { get; set; }

        public TwoCommandParameters SideloadParameters { get; set; }

        public ThreeTextCommandParameters ThreeTextCommandParameters { get; set; }

        public FiveTextCommandParameters FiveTextCommandParameters { get; set; }

        public TwoCommandParameters InstallTwoCommandParameters { get; set; }

        public TwoCommandParameters UninstallTwoCommandParameters { get; set; }

        public TwoCommandParameters ExecuteSingleCommandParameters { get; set; }

        public ExecuteCommandParameters ExecuteCommandsParameters { get; set; }

        public BackupParameters BackupParameters { get; set; }

        public TwoCommandParameters RestoreParameters { get; set; }

        #endregion



    }
}

