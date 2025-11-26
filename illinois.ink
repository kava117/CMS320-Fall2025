->NorthDakota


=== SouthDakota === 
#speaker: Player 
I thought nothing could get creepier than the last place, but I stand corrected. 
Oh and would you look at that, just when I thought thing's couldn't get scarier, there's an old women on the porch there.
Let me not be too judgemental. 
"Excuse me ma'am, do you know about the evacuation."
#speaker: Carol
"If I hear one more hippie s













=== NorthDakota ===
#speaker: Player 
"Wow, this place kinda reminds me of my old campus. What a small world we live in." 
You notice an... odd.. looking man running around the grassy field infront of what appears to be the science building. 

#speaker: Dr. Thompson 
"HEY! YOU THERE! Stay back, and I mean it, don't come ANY closer to me." 
#speaker: Player
This gut is a nut job I can already tell. 
"Woah woah, I don't mean any harm. I just stumbled across this campus on my drive to the bunker." 
#speaker: Dr. Thompson 
"Bunker you say, where.. the government is. Fascinating... very very fascinating..."
#speaker: Player 
* "Hey buddy are you ok?"
    ->ND2
* Why are you acting so... strange?"
    ->ND2
    
== ND2 ===
#speaker: Dr. Thompson 
- "I have a secret to tell you, but you can't tell ANYONE. Not even anyone on that little phone of yours. YOU SWEAR?"
#speaker: Player 
* * "Alright man I swear I swear, whatever you say is safe with me." 
    ->ND3
* * "You're insane, I don't even know you." 
    ->ND3

== ND3 ==
#speaker: Dr. Thompson 
"My name is Dr. Shaun Thompson, Ph. D in biotechnology. And today, November 6th, 1995 marks the date I found the cure for the radioactive sporestorm that is threatening North America. 
#speaker: Player 
* * "I should really get going now..."
    #speaker: Dr. Thompson
    "Not quite yet my friend, there is still much to discuss."
    ->ND4
* * A cure? That sounds a little too good ot be true don't you think?"
    #speaker: Dr. Thompon
    "Do you doubt Dr. Thompson?? That's absurd. My spore neautrilizer is by far the most advanced creation the governmetn could ever witness." 
    ->ND4
    
=== ND4 ==
#speaker: Dr. Thompson
"If only I could make it back to Washington with this news, I could be the greatest hero of the 20th century." 
#speaker: Player
"Washington you say?"
#speaker: Dr. Thompson
"Well yes, that is where head government bunker is correct? I've been working so hard in my office I didn't even think of how I will get there." 
#speaker: Player 
* "Well, I'm on my way there now. Is it something I can take with me?" 
    #speaker: Dr. Thompson
    "OH HEAVENS NO. Tools like these cannot be delivered without a professional like me around. I must accompany you." 
    #speaker: Player
    * * "Well doc, if that's the only way then so be it, hop in."
        -> DOCJOIN
    * * "I think it's probably safest if you stay here, sorry doc."
        #speaker: Dr. Thompson
        "I understand, well, maybe with the leftover parts the physics professors left behind I could create a make shift teleporter. Tally Ho!"
        #speaker: Player
        "Alright well just... be safe and uh... dont't burn anything down!"
        Huh, well anyways. 
        * * * I should probably check that shed over there for some gasoline while I'm here. 
        -> END
        * * * Time to hit the road, I don't want wanna be by this lunatic for any second longer. 
        -> END
        
        
#speaker: Player 
* "If you promise you won't zap me with any of your fancy trinkets, I could let you join me on my drive." 
    ->DOCJOIN
    === DOCJOIN=== 
    #speaker: Dr. Thompson
    "Well isn't this a joyous set of events. I shall join you on your journey to Washington State and we shall save the planet!"
    "Quick! Let's rummage through the old janitor shed for some extra gasoline. It won't take too long" 
    #speaker: Player 
    * * Works for me, I could always benefit from some free gas." -3 Hours #hours: 3
    
    * * "It's probably best if we hit the road now, don't want to be driving too late." 
#speaker: Dr. Thompson
- "Well Tally Ho! Let's be on our way"
#speaker: Player 
What a strange guy, but surely he's trustworthy... right?
->END
        
->END













=== Nebraska === 
#speaker: Player 
"Holy shit this place is like a ghost town."
As you approach the closed corner market, you notice a man sitting on the bench all alone.
You roll your window down as you approach. 

"Excuse me sir, are you ok out there?" 
#speaker: Matt
"God is that you?"    
#speaker: Player
* "No.. over here to your right.. the only car on the road.."
* "Hey dipship, I'm in the car right next to you." 

#speaker: Matt
- "Oh, I apologize. I'm a little loopy from being out here in the cold." 

#speaker: Player 
"It's ok, what are you doing out here anyway?" 

#speaker: Matt
"I was supposed to catch a flight to Idaho to see my family, but of course all the airports shut down so now I'm stuck in who knows where." 

#speaker: Player
* "Ouch thats tough, can't imagine being stuck out here in this weather." 
    #speaker: Matt
    "I bet the heat in your car feels pretty nice right about now. 
    
* "I'm so sorry, when is the last time you saw them?"
    #speaker: Matt
    "It's been 4 months. I was on an international work trip when my layover got cancelled. Hmm, just my luck."
   
#speaker:  
- "Oh wow." 

#speaker: Matt
"Sorry, I don't mean to dump all this on you." 

#speaker: Player 
"It's all good, I can imagine you're stressed."

#speaker: Matt
"Hey man, I hate to ask this but... do you think I could hitch a ride to Idaho. I have no other option man im desperate."

#speaker: Player 
hmm, if I pick this man up I have to drop him off in Idaho. Is it too far out of my way?

* "I don't know if I have any more room in my car man, I'm sorry."
    #speaker: Matt
    "No worries man, I totally get it. I am a stranger after all." 
    "By the way, there's an abandoned grocery store up here on the corner, I would check it out if you're looking for supplies." 
    #speaker: Player 
    "Thanks man. I should be off now but, stay safe out there!"
    You slowly drive away from Matt on the corner. You see him look longingly at your car from the rear view mirror. 
    * * Stop for supplies at the grocery store.
        * * * Food would be best. 
        ->END
        * * * Definitly some water. 
        -> END
    * * Keep driving. 
        "I've still got quite a bit to go, let's hit the road. 
        -> END






* "Of course you can! No man could leave someone stranded out here in this condition." 
    #speaker: Matt
    "Oh man, you have no idea how much of a blessing this is. I don't have much to offer, but I have some food for us to share." #food: true 
    #speaker: Player
    "Anything you have would be of help, thank you." 
    #speaker: Matt
    "By the way, there's an empty grocery store up here on the corner. If we want to stop there I can see what they left behind." 
    #speaker: Player 
        * * "That sounds like a perfect plan." 
            #speaker: Matt 
            "What would you like me to get?" 
            #speaker: Player 
            * * * "Food would be best"
                #speaker: Matt
                "Alright, let's hit it." 
                ->END
            * * * "Definitly some water"
            #speaker: Matt
            "Alright, let's hit it." 
                    ->END
        * * "I think it's best if we keep driving for now." 
            #speaker: Matt
            "Probably a good idea. Well let's hit the road, we have a long drive ahead of us!"
            #speaker: Player  to themself 
            heh, yeah... "we"...
                    ->END
    
    

-> END








-> Illinois


=== Illinois ===

# speaker: Player
Never thought I would actually step foot in Illinois, but here we are. There's always a first for everything.
Excuse me, mister, do you know where I could find the closest gas station?

# speaker: Peter
Hrmph. I've seen plenty of punks like you coming by here causing all sorts of trouble. *cough cough* Be on your way now.

# speaker: Player
Please sir, I'm just looking for some supplies to help on my drive. I've come from Florida and I'm only about halfway to the bunker.

# speaker: Peter
Bunker?! Don't tell me you believe in all this alien nonsense. *cough cough*
I've seen plenty of these so-called viruses come and go. Haven't gotten me yet, so why should I leave?

#speaker: Player 
* [Based on what I've seen myself, I wouldn't be too sure of that. This virus is messing people up bad.] 
    # speaker: Peter
    Nothing a little *cough* medicine can't fix.
    -> conversation_continue

* [Listen, I don't blame you. I don't know how much of this I believe either, but they're closing down the state lines. Everyone has to leave.]
    # speaker: Player
    # speaker: Peter
    Not me. I'm staying right here with the r- *cough* ... excuse me ... the rest of my farm.
    -> conversation_continue

=== conversation_continue ===

# speaker: Player
I hear ya, man. But anyway, do you know of any gas stations around here?

# speaker: Peter
Not any open within at least an hour. I'll tell ya what though — since I believe we see eye to eye about most things...
How about you follow me up the way to my cabin? I'll let you leave with a few things.

* [That's awfully generous, but I should really get going. Can't get caught in any more traffic.] # speaker: Player
    # speaker: Peter
    I know that feeling. Well, feel free to look around the street here. People leave things around all the time.

    * * [Thank you sir. Are you sure you don't want to hitch a ride to the bunker? I've got more room in the back.]
        # speaker: Player
        # speaker: Peter
        So the roads really are that bad? I guess it can't be that bad of an idea... *cough cough* I guess I'll hitch a ride. Thanks, man.

        * * * [Continue on the drive.]
            -> END

        * * * [Search the nearby road for leftover supplies. -4 hours]
            # hours: -4
            -> END

    * * [Stay safe out there. I hope the storm doesn't cause too much harm to your farm.]
        -> END

* [That would be incredibly helpful. Anything you could offer is great. -4 hours]
    # speaker: Player
    # hours: -4

    # speaker: Peter
    I figured my supplies aren't doing anyone justice just sitting around here doing nothing.

    * *  [Search for food and gas]
        # food: true
        # gas: true
        -> END

    * * [Search for gas and water]
        # gas: true
        # water: true
        -> END

    * *  [Search for food and water]
        # food: true
        # water: true
        -> END

    # speaker: Peter
    As much as a pain you young folk are, I wish you the best of luck out there.
    I wouldn't want to be out on those roads, but more importantly, I can't leave my crops here alone.

    -> END
    
    








