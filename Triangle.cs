using System;
public class Triangle
{
    double x,y;
    double curr;
    public Triangle(double a,double b,double c){
        x=a;
        y=b;
        curr=c;
    }
    public double Area (){
        return Math.Sqrt(3)/4*curr*curr;
    }
    public double Perim (){
        return curr*3;
    }
    public void Coordinates (){
        System.Console.WriteLine($"{x} {y}");
        System.Console.WriteLine($"{x+curr/2} {y+Math.Sqrt(3)/2*curr}");
        System.Console.WriteLine($"{x+curr} {y}");
    }
    public double Side (){
        return curr; 
    }
    public void Resize (double c){
        curr=c;
    }
    public void Move (int a, int b){
        x=a;
        y=b;
    }
}