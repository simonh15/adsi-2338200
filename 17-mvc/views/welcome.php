<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<title>MVC -OOP</title>
<link rel="stylesheet" href="public/css/custom.css">
<script src="public/js/tailwind-3.2.1.js"></script>
</head>
<body>
<main class="my-10 mx-auto p-10 w-11/12 md:w-8-12 bg-black/40 rounded-xl">
    <header class="text-white/80 flex gap-4 justify-center items-center pb-4 border-b-2">
        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-12 h-10">
            <path stroke-linecap="round" stroke-linejoin="round" d="M15 19.128a9.38 9.38 0 002.625.372 9.337 9.337 0 004.121-.952 4.125 4.125 0 00-7.533-2.493M15 19.128v-.003c0-1.113-.285-2.16-.786-3.07M15 19.128v.106A12.318 12.318 0 018.624 21c-2.331 0-4.512-.645-6.374-1.766l-.001-.109a6.375 6.375 0 0111.964-3.07M12 6.375a3.375 3.375 0 11-6.75 0 3.375 3.375 0 016.75 0zm8.25 2.25a2.625 2.625 0 11-5.25 0 2.625 2.625 0 015.25 0z" />
        </svg>
        <h1 class="text-3xl font-bold">List All Users</h1>
    </header>
    <section>
        <a href="" class="mt-8 p-2 flex justify-center items-center w-4/12 xl:w-2/12 gap-2 transition text-white/80 bg-green-600/60 rounded hover:scale-105 trainsition hover:bg-green-600/70">
            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
                <path stroke-linecap="round" stroke-linejoin="round" d="M19 7.5v3m0 0v3m0-3h3m-3 0h-3m-2.25-4.125a3.375 3.375 0 11-6.75 0 3.375 3.375 0 016.75 0zM4 19.235v-.11a6.375 6.375 0 0112.75 0v.109A12.318 12.318 0 0110.374 21c-2.331 0-4.512-.645-6.374-1.766z" />
            </svg>
            Add User
        </a>
        <table class="mt-6 w-[100%] mx-auto border-collapse">
            <thead class="bg-black/40 text-white/80 font-bold border-b-2 border-white/60">
                <tr>
                    <th class="rounded-tl-md p-2">ID</th>
                    <th>Full Name</th>
                    <th>Photo</th>
                    <th class="rounded-tr-md">Actions</th>
                </tr>
            </thead>
            <tbody>
                <tr class="bg-white/20 odd:bg-white/10">
                    <td>1</td>
                    <td>La chabuki</td>
                    <td>
                        <img src="public/imgs/nophoto.png" class="w-10 rounded-full">
                    </td>
                    <td>
                        <a href="">S</a>
                        <a href="">U</a>
                        <a href="">D</a>
                    </td>
                </tr>
            </tbody>
        </table>
    </section>
</main>
</body>
</html>
</html>