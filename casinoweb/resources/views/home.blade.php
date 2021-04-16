
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/e060aa5150.js" crossorigin="anonymous"></script>
    <script src="{{ asset('js/app.js') }}" defer></script>

    <!-- Fonts -->

    <!-- Styles -->
    <title>CasinoLotto</title>
</head>
<body>
<div class="container-nav">
    <div class="nav" >
        <div class="nav-image">
            <a href="{{ redirect('home') }}" style="margin-bottom: 5px"><img src="logo.PNG" alt="logo"></a>
        </div>

        {{--<div class="rightsection">--}}
            {{--<i class="fas fa-comments"></i>--}}
            {{--<i class="fas fa-bell"></i>--}}
        {{--</div>--}}
        <div class="games">
            <a href="Hondenrace.exe">Dograces</a>
            <a href="DogRaces">Rock Paper Scissors</a>
            <a href="DogRaces">3 card poker</a>
        </div>
        <p style="color: white">₿ {{ Auth::user()->user_credits }} </p>


        <div class="profilesection">

        @if (!Auth::check())
                <a href="login">Login</a>
                <a href="register">Register</a>
            @else
                <li class="nav-item dropdown">
                    <a id="navbarDropdown" class="nav-link dropdown-toggle" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        {{ Auth::user()->user_name }} <span class="caret"></span>
                    </a>

                    <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdown">
                        <a class="dropdown-item" href="{{ route('logout') }}"
                           onclick="event.preventDefault();
                                                     document.getElementById('logout-form').submit();">
                            {{ __('Logout') }}
                        </a>

                        <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                            @csrf
                        </form>
                    </div>
                </li>
            @endif

        </div>
    </div>
</div>
<div class="container-hero">
    <div class="hero">
        <div class="hero-datesection">
            <div class="hero-date-day">
                <p>
                    <?php echo date('l'); ?>
                </p>
            </div>
            <div class="hero-date-date">
                <p><?php
                    echo date('d F Y');?></p>
            </div>
        </div>
        @foreach($alldata as $message)
            <div class="hero-sector1" >
                <div class="sector1-data">
                    {{--<p class="temp_data" style="color: orange;">{{$message->user_id}}</p>--}}
                    <p class="temp_data" style="color: orange;">Sander van Deurzen</p>
                    <p class="temp_text" style="color: #ffffff;">{{$message->message}}</p>
                </div>

            </div>
        @endforeach
        <form action="{{ url('/sendmessage/')}}" accept-charset="UTF-8" method="post">
            @csrf
            <input type="text" placeholder="maak je bericht" name="message">
            <input type="submit" value="Versturen!">

        </form>
    </div>
    <div class="hero-graphs">
        <div class="graph-header">
            <div class="graph-header-left">
                <i class="fas fa-clipboard-list"></i>
                <p>Current leaderboard (in credits)</p>
            </div>

        </div>
        <div class="graph-items">
                <ul>
                    @foreach($leaderboardData as $players)
                        <i><p>{{$players->id}} {{$players->user_name}} {{$players->user_credits}}</p></i>
                    @endforeach
                </ul>
        </div>
    </div>
</div>
</body>
</html>