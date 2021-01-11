using System;

namespace Car
{
    /*
     クラスの定義
    class クラス名 { クラスの実装 }
     */

    //車を表すクラス⇒車に対する操作には何があるか
    /*
        車に乗る
        車から降りる
        エンジンを入れる
        車を運転する
        車を止める
    　　曲がる
    　　バックする
    　　ガソリンを入れる
     */

    //操作を実装するために記憶する情報
    /*
        総合走行距離
    　　ガソリンの量
        走行時速
        走行時間
     */

    /// <summary>
    /// 車クラス
    /// </summary>
    class Car
    {
        ////メンバー変数
        //public double totalRunKm; ///走行距離(km)
        //public double gasL;       ///ガソリン量(L)
        //public double runKmH;     ///走行速度(km/h)
        //public double timeM;      ///走行時間(分)

        //カプセル化を行ったメンバー変数
        private double totalRunKm; ///走行距離(km)
        private double gasL;       ///ガソリン量(L)
        private double runKmH;     ///走行速度(km/h)
        private double timeM;      ///走行時間(分)

        //変数初期化子
        public bool Fault = false; ///故障しているかどうか(falseなら正常)

        //コンストラクター～newを用いてインスタンス化した際に呼び出されるメソッド

        //引数なしコンストラクタ
        //コンストラクター初期化子～あるコンストラクターから別のコンストラクターを呼び出す
        //下の例の場合は引数付きコンストラクターを適用している
        //変数初期化子⇒コンストラクター初期化子⇒コンストラクター本体の順番で実行

        ///<summary>
        ///
        /// </summary>
        public Car():this(100,0,0)
        {

            this.totalRunKm = 0;

        }
        //引数付きコンストラクタ
        public Car(double gasL, double runKmH,double timeM)
        {
            this.gasL = gasL;
            this.runKmH = runKmH;
            this.timeM = timeM;
        }

        //アクセサー～メンバー変数の取得や変更を行うメソッド
        //    ⇒privateにしたら設けるメソッド
        /*
         * C++やJavaの場合だとフィールドの数だけアクセサーが増える
         * 利用者側からはフィールドに直接代入したほうが見栄えが良い
         * ⇒C#ではクラス内部から見るとメソッドのように振る舞い、利用者側からみるとメンバー変数のようにふるまう機能
         * ⇒プロパティ
         * プロパティ名とフィールド名は違う書き方でないとエラーが起きる
         * アクセスレベル 型名 プロパティ名{
         *      get
         *      set
         * }
         */
        public double TotalRunKm
        {
            //ゲッター(getter)
            get { return this.totalRunKm; }
            //セッター(setter)
            //アクセスレベルの設定Ver.2.0
            private set { this.totalRunKm = value; }
        }
        public double GasL
        {
            //ゲッター(getter)
            get { return this.gasL; }
            //セッター(setter)
            set { this.gasL = value; }
        }

        public double RunKmH
        {
            //ゲッター(getter)
            get { return this.runKmH; }
            //セッター(setter)
             set { this.runKmH = value; }
        }

        public double TimeM
        {
            //ゲッター(getter)
            get { return this.timeM; }
            //セッター(setter)
            set { this.timeM = value; }
        }


        //メソッド


        ///<summary>
        ///走行する
        ///</summary>
        public void runCar()
        {
            double runKm = this.runKmH * (this.timeM / 60);
            runKm = Math.Round(runKm);
            this.totalRunKm += runKm;
            Console.WriteLine($"走った距離は{runKm}です");
        }

        ///<summary>
        ///停止する
        /// </summary>
        public void stopCar()
        {
            Console.WriteLine("車にブレーキを掛けました");
        }

        /// <summary>
        /// 走行メーターを確認する
        /// </summary>
        public void dispMeter()
        {
            Console.WriteLine($"今の総合走行距離は{this.totalRunKm}kmです");
        }

        /// <summary>
        /// ガソリンを入れる
        /// </summary>
        /// <param name="gasL"></param>
        public void enterGas(double gasL)
        {
            /*gasL = gasL
              引数を参照してしまうためこの書き方だと引数に引数
              を代入するだけで意味がない
              thisアクセス～ローカル変数と同名のフィールドがあったときにフィールドのほうを参照する
             */
            this.gasL = gasL;
            Console.WriteLine($"ガソリンを{gasL}リットル補充しました");

        }

  

    }

    class World {

        public static void Main()
        {
            //クラスの利用
            //クラス名 変数名 = new クラス名();
            Car car = new Car();  //クラスという設計図をもとにインスタンス(実体)を生成する


            /*
             今生成したインスタンスには何も入ってない状態
            ⇒データに値を入れる必要がある
            変数名.メンバー名
            */
            car.RunKmH = 40; //時速
            car.TimeM = 100; //走行時間(分)

            /*
             インスタンスを操作する
             変数名.メソッド名
             */
            car.runCar();
            car.stopCar();
            car.dispMeter();  //67
            car.runCar();
            car.dispMeter();  //134

        }

    }








}
