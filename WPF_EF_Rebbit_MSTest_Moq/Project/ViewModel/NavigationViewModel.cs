﻿using System.Windows.Input;
using WPF_EF_Rebbit_MSTest_Moq.Framework;
using WPF_EF_Rebbit_MSTest_Moq.Framework.Base;
using WPF_EF_Rebbit_MSTest_Moq.Project.View;

namespace WPF_EF_Rebbit_MSTest_Moq.Project.ViewModel
{
	public class NavigationViewModel: BaseViewModel
	{
		public NavigationViewModel() {
			InitCommands();
		}

		public ICommand CardSectionOpenCommand { get; private set; }
		public ICommand IndicatorSectionOpenCommand { get; private set; }

		private void InitCommands() {
			CardSectionOpenCommand = new DelegateCommand(OpenCards);
			IndicatorSectionOpenCommand = new DelegateCommand(OpenIndicators);
		}

		private void OpenCards(object obj) {
			var cardSection = new CardSection {
				DataContext = new CardSectionViewModel(),
				ShowInTaskbar = false
			};
			cardSection.ShowDialog();
		}

		private void OpenIndicators(object obj) {
			var indicatorSection = new IndicatorSection {
				DataContext = new IndicatorSectionViewModel(),
				ShowInTaskbar = false
			};
			indicatorSection.ShowDialog();
		}
	}
}