using System;
public class Square
{
    double x,y;
    double w;
    double curr;
    /// <summary>
    /// Создание квадрата. Задается координата левого нижнего угла и длина стороны.
    /// </summary>
    /// <param name="a">Координата х</param>
    /// <param name="b">Координата у</param>
    /// <pafram name="c">Длина стороны</param>
    public Square(double a,double b,double c){
        x=a;
        y=b;
        curr=c;
        //curr=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    }
   /// <summary>
   /// Площадь квадрата
   /// </summary>
   /// <returns>Площадь</returns>
    public double Area(){
        return curr*curr;
    }
    /// <summary>
    /// Диагональ квадрата
    /// </summary>
    /// <returns>Длину диагонали</returns>
    public double Diagonal(){
        return Math.Sqrt(2*curr*curr);
    }
    /// <summary>
    /// Периметр квадрата
    /// </summary>
    /// <returns>Периметр</returns>
    public double Perim(){
        return curr*4;
    }
   
    /// <summary>
    /// Именение размера квадрата
    /// </summary>
    /// <param name="c">Новая длина стороны квадрата</param>
    public void Resize(double c){
        curr=c;
    }
    /// <summary>
    /// Изменение координат квадрата
    /// </summary>
    /// <param name="a">Новая координата х</param>
    /// <param name="b">Новая координата у</param>
    public void Move(int a, int b){
        x=a;
        y=b;
    }
    /// <summary>
    /// Возврат длины стороны квадрата
    /// </summary>
    /// <returns>Длина стороны квадрата</returns>
    public double Side (){
        return curr;
    }
}