using NCalc;
//Надеюсь не расчитывалось, что я напишу собственный парсер для мат выражений)
public class Calculator
{
	public double Calculate(string expression)
	{
		var e = new Expression(expression);
		return Convert.ToDouble(e.Evaluate());
	}
}
