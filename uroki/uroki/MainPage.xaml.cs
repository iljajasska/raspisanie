using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace uroki
{
    public partial class MainPage : ContentPage
    {
        //BoxView box;
        Label nomer0, nomer1, nomer2, nomer3, nomer4, nomer5, nomer6, nomer7, nomer8,nomer9, pon, vtor, sred, chet, pyat, urok1, urok2, urok3, urok4, urok5, urok6, urok7, urok8, urok9, urok10, urok11, urok12, urok13, urok14;
        //Frame frm, frm2;
        public MainPage()
        {
            Grid abs = new Grid();
            for (int i = 0; i < 4; i++)
            {
                abs.RowDefinitions.Add(new RowDefinition
                { Height = new GridLength(1, GridUnitType.Star) });
            }
            for (int j = 0; j < 3; j++)
            {
                abs.ColumnDefinitions.Add(new ColumnDefinition
                { Width = new GridLength(1, GridUnitType.Star) });
            }
            nomer1 = new Label { BackgroundColor = Color.White, Text = "1" };
            abs.Children.Add(nomer1, 1, 0);
            nomer2 = new Label { BackgroundColor = Color.White, Text = "2" };
            abs.Children.Add(nomer2, 2, 0);
            nomer3 = new Label { BackgroundColor = Color.White, Text = "3" };
            abs.Children.Add(nomer3, 3, 0);
            nomer4 = new Label { BackgroundColor = Color.White, Text = "4" };
            abs.Children.Add(nomer4, 4, 0);
            nomer5 = new Label { BackgroundColor = Color.White, Text = "5" };
            abs.Children.Add(nomer5, 5, 0);
            nomer6 = new Label { BackgroundColor = Color.White, Text = "6" };
            abs.Children.Add(nomer6, 6, 0);
            nomer7 = new Label { BackgroundColor = Color.White, Text = "7" };
            abs.Children.Add(nomer7, 7, 0);
            nomer8 = new Label { BackgroundColor = Color.White, Text = "8" };
            abs.Children.Add(nomer8, 8, 0);
            nomer9 = new Label { BackgroundColor = Color.White, Text = "9" };
            abs.Children.Add(nomer9, 9, 0);
            pon = new Label { BackgroundColor = Color.White, Text = "Понедельник" };
            abs.Children.Add(pon, 0, 1);
            Grid.SetColumnSpan(pon, 2);
            vtor = new Label { BackgroundColor = Color.White, Text = "Вторник" };
            abs.Children.Add(vtor, 0, 2);
            Grid.SetColumnSpan(vtor, 2);
            sred = new Label { BackgroundColor = Color.White, Text = "Среда" };
            abs.Children.Add(sred, 0, 3);
            Grid.SetColumnSpan(sred, 2);
            chet = new Label { BackgroundColor = Color.White, Text = "Четверг" };
            abs.Children.Add(chet, 0, 4);
            Grid.SetColumnSpan(chet, 2);
            pyat = new Label { BackgroundColor = Color.White, Text = "Пятница" };
            abs.Children.Add(pyat, 0, 5);
            Grid.SetColumnSpan(pyat, 2);

            urok1 = new Label { BackgroundColor = Color.LightGreen, Text = "Keel ja \n Kirjandus \n \n \n B221" };
            abs.Children.Add(urok1, 1, 1);
            Grid.SetColumnSpan(urok1, 2);
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                urok1 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            urok1.GestureRecognizers.Add(tap1);

            urok2 = new Label { BackgroundColor = Color.LightPink, Text = "Võrgud ja seadm. \n \n \n A123" };
            abs.Children.Add(urok2, 3, 1);
            Grid.SetColumnSpan(urok2, 2);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += async (s, e) =>
            {
                urok1 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            urok2.GestureRecognizers.Add(tap2);

            urok3 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob.Rak \n \n \n E07" };
            abs.Children.Add(urok3, 6, 1);
            Grid.SetColumnSpan(urok3, 3);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += async (s, e) =>
            {
                urok1 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            urok3.GestureRecognizers.Add(tap3);

            urok4 = new Label { BackgroundColor = Color.LimeGreen, Text = "Transp.log.juht \n \n \n B002" };
            abs.Children.Add(urok4, 1, 2);
            Grid.SetColumnSpan(urok4, 3);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += async (s, e) =>
            {
                urok1 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            urok4.GestureRecognizers.Add(tap4);

            urok5 = new Label { BackgroundColor = Color.DarkGray, Text = "Inglise. w.hald \n \n \n B242" };
            abs.Children.Add(urok5, 5, 2);
            Grid.SetColumnSpan(urok5, 2);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += async (s, e) =>
            {
                urok1 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            urok5.GestureRecognizers.Add(tap5);

            urok6 = new Label { BackgroundColor = Color.DeepPink, Text = "Eesti keel \teise keelena \n \n \n B236" };
            abs.Children.Add(urok6, 7, 2);
            Grid.SetColumnSpan(urok6, 2);
            urok7 = new Label { BackgroundColor = Color.Violet, Text = "w.paig.sead \n \n \n A243" };
            abs.Children.Add(urok7, 1, 3);
            Grid.SetColumnSpan(urok7, 3);
            urok8 = new Label { BackgroundColor = Color.Green, Text = "Transp.log.juht \n \n \n B003" };
            abs.Children.Add(urok8, 4, 3);
            Grid.SetColumnSpan(urok8, 5);
            urok9 = new Label { BackgroundColor = Color.DarkViolet, Text = "Keemia \n eesti keeles \n \n \n B144" };
            abs.Children.Add(urok9, 9, 3);
            urok10 = new Label { BackgroundColor = Color.Violet, Text = "W.paig.sead \n \n \n A243" };
            abs.Children.Add(urok10, 1, 4);
            Grid.SetColumnSpan(urok10, 3);
            urok11 = new Label { BackgroundColor = Color.LightPink, Text = "Võrgud ja seadm. \n \n \n A123" };
            abs.Children.Add(urok11, 5, 4);
            Grid.SetColumnSpan(urok11, 2);
            urok12 = new Label { BackgroundColor = Color.DarkGray, Text = "Inglise W.hald \n \n \n B242" };
            abs.Children.Add(urok12, 7, 4);
            Grid.SetColumnSpan(urok12, 2);
            urok13 = new Label { BackgroundColor = Color.DarkViolet, Text = "Keemia \n eesti keeles \n \n \n B144" };
            abs.Children.Add(urok13, 1, 5);
            urok14 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob.Rak \n \n \n E07" };
            abs.Children.Add(urok14, 3, 5);
            Grid.SetColumnSpan(urok14, 3);

            Content = abs;
        }
    }
}
