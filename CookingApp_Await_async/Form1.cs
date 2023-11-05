using System.Diagnostics;

namespace CookingApp_Await_async
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            timer.Interval = 1000;
            timer.Start();
        }

        /*
            Omlet Tarifi;

            1) Yumurtalar� K�r
            2) Yumurtalar� ��rp
            3) Tuz Ekle
            4) Oca�� A�
            5) Tavay� Is�t
            6) Ya�� D�k
            7) Yumurtay� Ekle
            8) Pi�ir
            9) Servis Et
         */

        private void btnStartCookingSync_Click(object sender, EventArgs e)
        {
            PrepareScreenForStarting();

            var sw = Stopwatch.StartNew();

            YumurtalariKir();
            YumurtalariCirp();
            TuzEkle();
            OcagiAc();
            TavayiIsit();
            YagiDok();
            YumurtayiEkle();
            Pisir();
            ServisEt();

            sw.Stop();
            AddLog();
            AddLog($"Toplam Yemek Pi�irme S�resi: {sw.ElapsedMilliseconds:0} MS");
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            PrepareScreenForStarting();

            var sw = Stopwatch.StartNew();


            var yumurtaTaskGroup = await YumurtalariKirAsync()
                .ContinueWith(async _ =>
                {
                    await YumurtalariCirpAsync();
                    await TuzEkleAsync();
                }, TaskScheduler.FromCurrentSynchronizationContext());

            var ocakTaskGroup = await OcagiAcAsync()
                .ContinueWith(async _ =>
                {
                    await TavayiIsitAsync();
                    await YagiDokAsync();
                    await YumurtayiEkleAsync();
                }, TaskScheduler.FromCurrentSynchronizationContext());

            await Task.WhenAll(yumurtaTaskGroup, ocakTaskGroup);


            await PisirAsync();
            await ServisEtAsync();



            sw.Stop();
            AddLog();
            AddLog($"Toplam Yemek Pi�irme S�resi: {sw.ElapsedMilliseconds:0} MS");
        }

        

        #region Sync Methods

        public void YumurtalariKir()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalar K�r�ld�");
            AdjustButtons(1);
        }

        public void YumurtalariCirp()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar ��rp�ld�");
            AdjustButtons(2);

            // 1) --------            ------------
            // 2)         ------------
        }

        public void TuzEkle()
        {
            Task.Delay(200).Wait();
            AddLog("Tuz Eklendi");
            AdjustButtons(3);
        }

        public void OcagiAc()
        {
            Task.Delay(500).Wait();
            AddLog("Ocak A��ld�");
            AdjustButtons(4);
        }

        public void TavayiIsit()
        {
            Task.Delay(1000).Wait();
            AddLog("Tava Is�nd�");
            AdjustButtons(5);
        }

        public void YagiDok()
        {
            Task.Delay(750).Wait();
            AddLog("Ya� Tavaya D�k�ld�");
            AdjustButtons(6);
        }

        public void YumurtayiEkle()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Tavaya D�k�ld�");
            AdjustButtons(7);
        }

        public void Pisir()
        {
            Task.Delay(2000).Wait();
            AddLog("Yumurtalar Pi�ti");
            AdjustButtons(8);
        }

        public void ServisEt()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Servis Edildi");
            AdjustButtons(9);
        }

        #endregion


        #region Async Methods

        public async Task YumurtalariKirAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalar K�r�ld�");
            AdjustButtons(1);
        }

        public async Task YumurtalariCirpAsync()
        {
            await Task.Delay(750);
            AddLog("Yumurtalar ��rp�ld�");
            AdjustButtons(2);
        }

        public async Task TuzEkleAsync()
        {
            await Task.Delay(200);
            AddLog("Tuz Eklendi");
            AdjustButtons(3);
        }

        public async Task OcagiAcAsync()
        {
            await Task.Delay(500);
            AddLog("Ocak A��ld�");
            AdjustButtons(4);
        }

        public async Task TavayiIsitAsync()
        {
            await Task.Delay(1000);
            AddLog("Tava Is�nd�");
            AdjustButtons(5);
        }

        public async Task YagiDokAsync()
        {
            await Task.Delay(750);
            AddLog("Ya� Tavaya D�k�ld�");
            AdjustButtons(6);
        }

        public async Task YumurtayiEkleAsync()
        {
            await Task.Delay(750);
            AddLog("Yumurtalar Tavaya D�k�ld�");
            AdjustButtons(7);
        }

        public async Task PisirAsync()
        {
            await Task.Delay(200);
            AddLog("Yumurtalar Pi�ti");
            AdjustButtons(8);
        }

        public async Task ServisEtAsync()
        {
            await Task.Delay(750);
            AddLog("Yumurtalar Servis Edildi");
            AdjustButtons(9);
        }

        #endregion


        private void AddLog(string logStr = "")
        {
            if (!string.IsNullOrEmpty(logStr))
                logStr = $"[{DateTime.Now:dd:MM.yyyy HH:mm:ss}] - {logStr}";

            lbLogs.Items.Add(logStr);
            lbLogs.TopIndex = lbLogs.Items.Count - 1; // Locate the last row
        }

        private void PrepareScreenForStarting()
        {
            foreach (Control control in pnlButtons.Controls)
            {
                if (control is Button btn)
                    btn.BackColor = SystemColors.Control;
            }

            pnlButtons.Update();

            lbLogs.Items.Clear();
        }

        private void AdjustButtons(int step)
        {
            Button btn = pnlButtons.Controls[$"btnStep{step}"] as Button;

            btn.BackColor = Color.LimeGreen;
        }


    }
}