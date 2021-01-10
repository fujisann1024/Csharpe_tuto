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
        //メンバー変数
        public double totalRunKm; ///走行距離(km)
        public double gasL;       ///ガソリン量(L)
        public double runKmH;     ///走行速度(km/h)
        public double timeM;      ///走行時間(分)


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
            Console.WriteLine($"今の総合走行距離は{totalRunKm}kmです");
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
            car.runKmH = 40; //時速
            car.timeM = 100; //走行時間(分)

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
