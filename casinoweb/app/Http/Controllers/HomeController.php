<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;
use App\Models\Messages;

class HomeController extends Controller
{
    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('auth');
    }

    /**
     * Show the application dashboard.
     *
     * @return \Illuminate\Contracts\Support\Renderable
     */
        public function index()
        {
            //data ophalen uit database
            $alldata = DB::table('messages')->get();
            $leaderboardData = DB::table('users')->orderByDesc('user_credits')->get();
            $b = DB::table('users')->orderByDesc('user_credits')->get();


            return view('home', [ 'alldata' => $alldata, 'leaderboardData' => $leaderboardData, 'leaderboardcount' => $b]);
        }


    public function sendMessage(Request $request)
    {
        // Stop data in de database
        $task = new Messages;

        $task->message = $request->message;
        $task->user_id = Auth::id();

        $task->save();
        return redirect('/home');
        //data ophalen uit database
//        DB:table('message')->insert([
//            'user_message' => $request['message'],
//            'user_id' => auth('id'),
//        ]);
//
//        $alldata = DB::table('messages')->get();
//        $leaderboardData = DB::table('users')->orderByDesc('user_credits')->get();
//        return view('home', [ 'alldata' => $alldata, 'leaderboardData' => $leaderboardData]);
    }
}
