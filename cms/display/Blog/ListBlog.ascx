﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListBlog.ascx.cs" Inherits="Ecommer.cms.display.Blog.ListBlog" %>
<link href="../../../css/Blog.css" rel="stylesheet" />


<div class="right-side-cart-area">

    <!-- Cart Button -->
    <div class="cart-button">
        <a href="#" id="rightSideCart">
            <img src="img/core-img/bag.svg" alt="">
            <span>3</span></a>
    </div>

    <div class="cart-content d-flex">

        <!-- Cart List Area -->
        <div class="cart-list">
            <!-- Single Cart Item -->
            <div class="single-cart-item">
                <a href="#" class="product-image">
                    <img src="img/product-img/product-1.jpg" class="cart-thumb" alt="">
                    <!-- Cart Item Desc -->
                    <div class="cart-item-desc">
                        <span class="product-remove"><i class="fa fa-close" aria-hidden="true"></i></span>
                        <span class="badge">Mango</span>
                        <h6>Button Through Strap Mini Dress</h6>
                        <p class="size">Size: S</p>
                        <p class="color">Color: Red</p>
                        <p class="price">$45.00</p>
                    </div>
                </a>
            </div>

            <!-- Single Cart Item -->
            <div class="single-cart-item">
                <a href="#" class="product-image">
                    <img src="img/product-img/product-2.jpg" class="cart-thumb" alt="">
                    <!-- Cart Item Desc -->
                    <div class="cart-item-desc">
                        <span class="product-remove"><i class="fa fa-close" aria-hidden="true"></i></span>
                        <span class="badge">Mango</span>
                        <h6>Button Through Strap Mini Dress</h6>
                        <p class="size">Size: S</p>
                        <p class="color">Color: Red</p>
                        <p class="price">$45.00</p>
                    </div>
                </a>
            </div>

            <!-- Single Cart Item -->
            <div class="single-cart-item">
                <a href="#" class="product-image">
                    <img src="img/product-img/product-3.jpg" class="cart-thumb" alt="">
                    <!-- Cart Item Desc -->
                    <div class="cart-item-desc">
                        <span class="product-remove"><i class="fa fa-close" aria-hidden="true"></i></span>
                        <span class="badge">Mango</span>
                        <h6>Button Through Strap Mini Dress</h6>
                        <p class="size">Size: S</p>
                        <p class="color">Color: Red</p>
                        <p class="price">$45.00</p>
                    </div>
                </a>
            </div>
        </div>

        <!-- Cart Summary -->
        <div class="cart-amount-summary">

            <h2>Summary</h2>
            <ul class="summary-table">
                <li><span>subtotal:</span> <span>$274.00</span></li>
                <li><span>delivery:</span> <span>Free</span></li>
                <li><span>discount:</span> <span>-15%</span></li>
                <li><span>total:</span> <span>$232.00</span></li>
            </ul>
            <div class="checkout-btn mt-100">
                <a href="checkout.html" class="btn essence-btn">check out</a>
            </div>
        </div>
    </div>
</div>
<!-- ##### Right Side Cart End ##### -->

<!-- ##### Breadcumb Area Start ##### -->
<div class="breadcumb_area breadcumb-style-two bg-img" style="background-image: url(img/bg-img/breadcumb2.jpg);">
    <div class="container h-100">
        <div class="row h-100 align-items-center">
            <div class="col-12">
                <div class="page-title text-center">
                    <h2><asp:Literal ID="FashionBlog" runat="server"></asp:Literal> </h2>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- ##### Breadcumb Area End ##### -->

<!-- ##### Blog Wrapper Area Start ##### -->
<div class="blog-wrapper section-padding-80">
    <div class="container">
        <div class="row">
            <asp:Literal ID="ltrNhomTinTuc" runat="server"></asp:Literal>
        </div>
    </div>
</div>