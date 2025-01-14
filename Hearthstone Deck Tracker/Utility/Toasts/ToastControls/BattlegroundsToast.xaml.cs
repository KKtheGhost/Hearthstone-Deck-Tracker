using System.Windows.Media.Animation;

namespace Hearthstone_Deck_Tracker.Utility.Toasts.ToastControls
{
	public partial class BattlegroundsToast : System.Windows.Controls.UserControl
	{
		private int[] _heroDbfIds;
		private int? _mmr;

		public BattlegroundsToast(int[] heroDbfIds, int? mmr)
		{
			InitializeComponent();
			_heroDbfIds = heroDbfIds;
			_mmr = mmr;
		}

		private void UserControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			(FindResource("StoryboardHover") as Storyboard)?.Begin();
		}

		private void UserControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			(FindResource("StoryboardNormal") as Storyboard)?.Begin();
		}

		private void UserControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			Helper.OpenBattlegroundsHeroPicker(_heroDbfIds, _mmr);
		}
	}
}
