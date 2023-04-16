from django.shortcuts import render

# Create your views here.

from django.http import HttpResponse
def home(request):
    return HttpResponse("<h1>Trang chủ</h1>")
def dangnhap(request):
    return HttpResponse("<h1>Dang nhap</h1>")
def detailProduct(request):
    return render(request, 'chitietsp.html')
def account(request):
    return render(request, 'account.html')
def cart(request):
    return render(request, 'cart.html')
def index(request):

    return render(request, 'index.html')