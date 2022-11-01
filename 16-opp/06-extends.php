<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Extends</title>
    <script src="public/js/tailwind-3.2.1.js"></script>
</head>
<body class=" bg-gradient-to-t
             from-indigo-900
             to-indigo-500
               min-h-screen ">

    <main class="m-10 
                 mx-auto 
                 max-w-lg
                 p-5
                 border-2
               border-indigo-400
               bg-white/5 
                 rounded">

        <h1 class=" m-5 
                    text-center 
                    text-4xl text-white 
                    text-opacity-50 
                    font-medium ">
           
            <a href="index.php" class="float-left 
                                        transition 
                                        hover:text-white-800 
                                        hover:-translate-x-1"> 

                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-10 h-10">
                    <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 9l-3 3m0 0l3 3m-3-3h7.5M21 12a9 9 0 11-18 0 9 9 0 0118 0z" />
                </svg>
            </a>
            Extends
        </h1>
        <section class="bg-black/10
                        text-white 
                        text-opacity-50 
                        p-5 
                        mt-10
                        min-h-[400px]
                        rounded">
                        <?php

                class Operation {
                    protected $number1;
                    protected $number2;

                    public function __construct($number1, $number2) {
                        $this->number1 = $number1;
                        $this->number2 = $number2;
                    
                    }

                }

                class Product extends Operation {
                    public function showResult() {
                        return '<p> <b>The product is: </b>'.($this->number1 * $this->number2).' </p>';
                    }
                }

                class Division extends Operation {
                    public function showResult() {
                        return '<p> <b>The division is: </b>'.($this->number1 / $this->number2).' </p>';
                    }
                }

                class Pow extends Operation {
                    public function showResult() {
                        return '<p> <b>The Exponetation is: </b>'.($this->number1 ** $this->number2).' </p>';
                    }
                }


                $oper = new Product(12, 9);
                echo $oper->showResult();

                $oper = new Division(1024, 32);
                echo $oper->showResult();

                $oper = new Pow(4, 4);
                echo $oper->showResult();

            ?>
        </section>

    </main>
    
</body>
</html>