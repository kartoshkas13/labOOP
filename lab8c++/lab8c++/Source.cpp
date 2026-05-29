#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>
using namespace std;

int main() {
    int n;
    cout << "Enter number of elements: ";
    cin >> n;

    vector<double> a(n);

    cout << "Enter array elements:\n";
    for (int i = 0; i < n; i++) {
        cin >> a[i];
    }

    double sumPositive = 0;
    for (double x : a) {
        if (x > 0) sumPositive += x;
    }


    int maxIndex = 0, minIndex = 0;

    for (int i = 1; i < n; i++) {
        if (fabs(a[i]) > fabs(a[maxIndex])) maxIndex = i;
        if (fabs(a[i]) < fabs(a[minIndex])) minIndex = i;
    }

    int left = min(minIndex, maxIndex);
    int right = max(minIndex, maxIndex);

    double product = 1;

    if (right - left > 1) {
        for (int i = left + 1; i < right; i++) {
            product *= a[i];
        }
    }

    //Сортування за спаданням
    sort(a.begin(), a.end(), greater<double>());


    cout << "\nSum of positive elements: " << sumPositive << endl;
    cout << "Product between max| | and min| |: " << product << endl;

    cout << "Sorted array (descending): ";
    for (double x : a) cout << x << " ";
    cout << endl;

    return 0;
}
