using System;
using CocosSharp;
using Xamarin.Forms;

namespace MyGame
{ 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GameScene gameScene = null;
            var gameView = new CocosSharpView()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                ViewCreated = (sender, e) =>
                {
                    var ccgameView = sender as CCGameView;
                    ccgameView.DesignResolution = new CCSizeI(100, 100);
                    gameScene = new GameScene(ccgameView);
                    ccgameView.RunWithScene(gameScene);
                }
            };
            MyGrid.Children.Add(gameView, 0, 0);
            MoveLeftButton.Clicked += (sender, e) => gameScene.MoveCircleLeft();
            MoveRightButton.Clicked += (sender, e) => gameScene.MoveCircleRight();
        }
    }
}
