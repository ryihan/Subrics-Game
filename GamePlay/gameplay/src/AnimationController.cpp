#include "Base.h"
#include "AnimationController.h"
#include "Game.h"
#include "Curve.h"

namespace gameplay
{

AnimationController::AnimationController()
    : _state(STOPPED)
{
}

AnimationController::~AnimationController()
{
}

void AnimationController::stopAllAnimations() 
{
    std::list<AnimationClip*>::iterator clipIter = _runningClips.begin();
    while (clipIter != _runningClips.end())
    {
        AnimationClip* clip = *clipIter;
        GP_ASSERT(clip);
        clip->stop();
        clipIter++;
    }
}

AnimationController::State AnimationController::getState() const
{
    return _state;
}

void AnimationController::initialize()
