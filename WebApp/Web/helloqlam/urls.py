from django.urls import path
from helloqlam import views
urlpatterns = [
    path("", views.home, name="home"),
    path("dangnhap", views.dangnhap, name="dangnhap"),
    path("detailproduct", views.detailProduct, name="detailproduct"),
    path("account", views.account, name="account"),
    path("cart", views.cart, name="cart"),
    path("index", views.index, name="index"),
]