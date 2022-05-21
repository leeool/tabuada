int numero, contador = 1, resultado;

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if  (numero <= 0){
    Console.WriteLine("Digite um numero positivo ou diferente de 0");
}

else{
    while (contador <= 10){
        resultado = contador * numero;
        Console.WriteLine($"{numero} x {contador++} = {resultado}");
}

}
