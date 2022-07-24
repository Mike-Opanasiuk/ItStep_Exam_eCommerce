import { FC } from "react";
import { Route, Routes } from "react-router-dom";
import { Header } from "@layout/header";
import { GoodsView } from "./components/views/goods";
import { ProductView } from "./components/views/product";
import { SignView } from "./components/views/sign";
import { CartView } from "./components/views/cart";
import { HomeView } from "./components/views/home";

export const App: FC = () => {
  return (
    <div className="h-full flex flex-col">
      <Header />
      <main className="container-by-default flex-1">
        <Routes>
          <Route path="/" element={<HomeView />} />
          <Route path="/goods" element={<GoodsView />} />
          <Route path="/product/:id" element={<ProductView />} />
          <Route path="/cart" element={<CartView />} />
          <Route path="/sign" element={<SignView />} />
        </Routes>
      </main>
      <footer className="container-by-default h-16">
      </footer>
    </div>
  );
}