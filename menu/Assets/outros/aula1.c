#include <stdio.h>

Long fat(Long n);

int main(void){
    Long n;
    Long f;

    scanf("%d", &n);
    f = fat(n);
    return 0;
}

long fat(long n){

    if(n==1) return 1;
    else return n*fat(n-1);
}