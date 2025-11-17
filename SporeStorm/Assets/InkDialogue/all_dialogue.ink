-> Missouri
VAR onScreen = false

=== Missouri ===
It's hard to believe the news is real... a giant, infectious storm? That sounds like the plot to some horrible movie. #speaker: Player
* [What's next, zombies?]
* [This whole town is so empty...]
- You look around, gathering your bearings and trying to decide the best course of action. You weren't able to grab much from home...
* [I'm totally going to starve.]
* [Dying of dehydration doesn't sound fun.]
* [When's the last time I got gas?]
- Well, shit.
- Maybe you could collect supplies from around here? It's not like anyone is around to use it anymore.
- Yeah, that's a good idea. But what to look for first? There's only so many hours in the day...
* [Food, definitely. (-3 hours)] #food:true #hours:3
* [Water for sure. (-4 hours)] #water:true #hours:4
* [Can't get anywhere without gas. (-2 hours)] #gas:true #hours:2

--> END



=== Jane ===
It's hard to believe the news is real... a giant, infectious storm? That sounds like the plot to some horrible movie. #speaker: Player
* [What's next, zombies?] #speaker: Player
* [This whole town is so empty...] #speaker: Player
- You walk forward more, noticing a lone mechanic waiting outside what appears to be an abandoned garage.
    "What are you still doing here? They sent out the evacuation notice hours ago." #speaker: Jane
    * ["The same could be said about you, y'know."]
    - "Fair enough. What's the problem, anyway? You don't seem to rushed to get out of here." #speaker: Jane
        * ["I just find this all hard to believe. A mutant storm full of spores?"]
            "I wouldn't be too sure about that. I've seen some of the people they've been wheeling across the street, and it looks pretty bad." #speaker: Jane
            "Rashes and blisters all over their face, some of them throwing up everywhere too." #speaker: Jane
        * ["I was on my way out now, just had to get my some things in order before I leave my life behind."]
            "I get it. I've heard it's pretty bad though - seen people around with blisters and rashes all over. Looks... painful."
    - * ["God, that's awful. Maybe the news was right for once. But, if you saw it all, why aren't you leaving?"]
        "Can't, the government shut down the buses. I got left here to tough it out."
            * * ["It wouldn't feel right leaving you stranded, can I offer a ride?"]
                "Are you sure? I wouldn't want to be a burden. I've handled a lot in my life, some mushrooms shouldn't be too hard to deal with."
            * * * ["No, please, I insist. No decent human could leave someone else here stranded."] #joining: true
                    "Then I accept. My name's Jane, by the way - figured you might want to know before you let me in your car."
                    * * * * ["Pleasure to meet you Jane. It looks like we've got a long road ahead of us."]
                    -> END
            * * ["Probably a good idea... I better head out early while I can. Good luck out there."]
                "Yeah, I get it. No sense in both of us waiting around for something we can't stop."
                * * * ["I'll keep that in mind. Stay safe."]
                    "You too, kid. Drive safe out there."
                    * * * * [As you turn around to head back to the car, you think to yourself. Maybe this is bigger than you thought?]
                    -> END
--> END