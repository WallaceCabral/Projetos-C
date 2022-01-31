/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações*/

int num,dent=0,fora=0;
Console.WriteLine("Quantos valores precisar ler");
num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{ int qnt= int.Parse(Console.ReadLine());
    
    if (qnt >= 10 && qnt <= 20)
        dent +=1;
    else if(qnt <10 || qnt >20)
        fora +=1;
}
Console.WriteLine("Dentro do intervalo tem:"+dent);
Console.WriteLine("Fora do intervalo tem:" + fora);