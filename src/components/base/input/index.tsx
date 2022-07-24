import { FC } from "react";

interface Props {
   className?: string;
   type?: "number" | "float" | "text";
   maxLength?: number;
   onChange?: (value: { text: string, number: number, float: number }) => void;
}

export const Input: FC<Props> = ({ onChange, className, maxLength, type = "text" }) => {

   const handleKeyDown = (event: React.KeyboardEvent<HTMLInputElement>) => {
      const value = event.currentTarget.value;

      switch (type) {
         case "number":
            if (/KeyA/.test(event.code)) {
               if (event.ctrlKey) {
                  break;
               }
            }
            if (!/Digit[0-9]|Backspace|Delete|Home|End|ArrowLeft|ArrowRight/.test(event.code)) {
               event.preventDefault();
            }
            break;
         case "float":
            if (/Period/.test(event.code)) {
               if (!value.includes(".")) {
                  break;
               }
            }
            if (/KeyA/.test(event.code)) {
               if (event.ctrlKey) {
                  break;
               }
            }
            if (!/Digit[0-9]|Backspace|Delete|Home|End|ArrowLeft|ArrowRight/.test(event.code)) {
               event.preventDefault();
            }
            break;
      }

      onChange && onChange({
         text: value,
         number: /number|test/.test(type) ? parseInt(value) : 0,
         float: /number|test/.test(type) ? parseFloat(value) : 0,
      });
   };

   return (
      <input
         className={className}
         type="text"
         maxLength={maxLength}
         onKeyDown={handleKeyDown}
      />
   );
};