Console.Write("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());
string num_text = Convert.ToString(num);
if (num_text.Length < 3)
{
  Console.WriteLine("Nothing to show");
}
else 
{
  
  Console.WriteLine(num_text[2]);
}