import { Input } from "@base/input";
import { FC } from "react";
import { Link } from "react-router-dom";
import { IconCart } from "../../icons/cart";
import { IconUser } from "../../icons/user";

export const Header: FC = () => {
   return (
      <header className="container-by-default">
         <nav className="h-16 flex items-center border-b">
            <Link to="/" className="flex gap-x-2">
               <img className="h-8 w-8" src="/logo.png" />
               <span className="leading-8 font-medium text-gray-800">Все Буде Україна</span>
            </Link>
            <Link to="/goods" className="ml-8">Товари</Link>
            <div className="ml-16">
               <Input type="float" className="border-b w-96 outline-none" />
            </div>
            <div className="ml-auto flex">
               <Link to="/cart" className="w-16 h-16 flex hover:bg-gray-50 border-b">
                  <IconCart className="h-6 w-6 text-gray-700 m-auto" />
               </Link>
               <Link to="/sign" className="w-16 h-16 flex hover:bg-gray-50 border-b">
                  <IconUser className="h-6 w-6 text-gray-700 m-auto" />
               </Link>
            </div>
         </nav>
      </header>
   )
}