function arr (limite) {
    let y = 0;
    let arr = [];

    for (let i = 0; i < limite; i++) {
        arr[y] = i
        y++
        
    }
    return arr
}

console.log(arr(5));