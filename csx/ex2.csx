public int[] limite (int n) {
    int[] x = new int [n];
    for (int i = n - 1; i >= 0; i--) {
        x[i] = i;
        
    }
    return x;
}


public void imprimir (int[] n) {
    for (int i = 0; i < n.Length; i++)
    {
        Console.Write(" {0}, ", n[i]);
    }
}

imprimir(limite(5))
